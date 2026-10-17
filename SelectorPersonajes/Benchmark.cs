using System.Diagnostics;

namespace SelectorPersonajes;

public class BenchmarkResults
{
    public int Quantity { get; init; }
    public int PersonasBases { get; init; }
    public int Repetitions { get; init; }
    public required string[] Operations { get; init; }
    public required string[] Details { get; init; }
    public required Dictionary<ListType, double[]> Time { get; init; }

    public bool Coinciden { get; init; }
}

public static class Benchmark
{
    public static BenchmarkResults Execute(
        IReadOnlyList<Persona> dataBase, int quantity, int repetitions, Action<string>? progress = null)
    {
        var data = GenerateData(dataBase, quantity);
        int accesses = Math.Min(500, quantity);
        int eliminations = Math.Max(1, Math.Min(1000, quantity / 10));

        var times = new Dictionary<ListType, double[]>();
        var detailsPerType = new Dictionary<ListType, string[]>();
        string[] operations = [];

        foreach (var type in Enum.GetValues<ListType>())
        {
            string name = ListFactory.Create(type).Name;
            double[] accumulated = [];
            string[] details = [];

            // Pasada 0 = calentamiento (JIT), no se promedia
            for (int past = 0; past <= repetitions; past++)
            {
                progress?.Invoke(past == 0
                    ? $"{name}: calentamiento…"
                    : $"{name}: past {past}/{repetitions}…");

                GC.Collect();
                GC.WaitForPendingFinalizers();

                var ops = onePast(type, data, accesses, eliminations);

                if (past == 0)
                {
                    operations = ops.Select(o => o.Operacion).ToArray();
                    accumulated = new double[ops.Count];
                    continue;
                }

                for (int i = 0; i < ops.Count; i++) accumulated[i] += ops[i].Ms;
                details = ops.Select(o => o.Detalle).ToArray();
            }

            times[type] = accumulated.Select(ms => ms / repetitions).ToArray();
            detailsPerType[type] = details;
        }

        var reference = detailsPerType[ListType.Custom];

        return new BenchmarkResults
        {
            Quantity = quantity,
            PersonasBases = dataBase.Count,
            Repetitions = repetitions,
            Operations = operations,
            Details = reference,
            Time = times,
            Coinciden = detailsPerType.Values.All(d => d.SequenceEqual(reference))
        };
    }

    
    private static Persona[] GenerateData(IReadOnlyList<Persona> baseDatos, int quantity)
    {
        IReadOnlyList<Persona> origin = baseDatos.Count > 0 ? baseDatos : Persona.Default();
        var data = new Persona[quantity];

        for (int i = 0; i < quantity; i++)
        {
            var b = origin[i % origin.Count];
            int ciclo = i / origin.Count;

            data[i] = new Persona(
                $"{b.Name} #{i + 1}",
                b.Species,
                b.Attack + (ciclo % 50) * 2,
                Math.Round(b.AtackSpeed + (ciclo % 10) * 0.05, 2),
                b.Level + ciclo % 50);
        }

        return data;
    }

    private static List<(string Operacion, double Ms, string Detalle)> onePast(
        ListType type, Persona[] data, int accesses, int eliminations)
    {
        var list = ListFactory.Create(type);
        var ops = new List<(string Operacion, double Ms, string Detalle)>();

        // Mide solo la acción; el detail (estadística calculada) se arma fuera del cronómetro
        void Op(string name, Action action, Func<string> detail)
        {
            var sw = Stopwatch.StartNew();
            action();
            sw.Stop();
            ops.Add((name, sw.Elapsed.TotalMilliseconds, detail()));
        }

        long totalAttack = 0, totalLevels = 0, additionLevels = 0;
        double dpsTotal = 0;
        Persona? best = null;
        var bySpecies = new Dictionary<string, int>();
        long pass = (long)(data.Length * 0.618) + 1;   // salta por toda la list

        Op("Insertar personajes",
            () => { foreach (var p in data) list.Add(p); },
            () => $"{list.Count:N0} personajes en la list");

        Op("Attack total y nivel promedio",
            () =>
            {
                foreach (var p in list.Iterate())
                {
                    totalAttack += p.Attack;
                    totalLevels += p.Level;
                }
            },
            () => $"Attack total {totalAttack:N0} | Level promedio {(double)totalLevels / list.Count:F2}");

        Op("DPS total (daño × velocidad)",
            () => { foreach (var p in list.Iterate()) dpsTotal += p.Dps; },
            () => $"DPS total {dpsTotal:N1} | DPS promedio {dpsTotal / list.Count:F2}");

        Op("Persona con mayor DPS",
            () =>
            {
                foreach (var p in list.Iterate())
                    if (best == null || p.Dps > best.Dps) best = p;
            },
            () => best == null ? "—" : $"{best.Name} ({best.Dps:F2} DPS)");

        Op("Conteo por especie",
            () =>
            {
                bySpecies.Clear();
                foreach (var p in list.Iterate())
                    bySpecies[p.Species] = bySpecies.GetValueOrDefault(p.Species) + 1;
            },
            () => string.Join(" | ", bySpecies
                .OrderBy(kv => kv.Key, StringComparer.Ordinal)
                .Select(kv => $"{kv.Key} {kv.Value:N0}")));

        Op($"Acceso por índice ×{accesses:N0}",
            () =>
            {
                for (int i = 0; i < accesses; i++)
                {
                    int indice = (int)((long)i * pass % list.Count);
                    additionLevels += list[indice].Level;
                }
            },
            () => $"Suma de niveles {additionLevels:N0}");

        Op("Order por nivel ↓",
            () => list.Order(Criteria.NivelDesc),
            () => $"1.º {list[0].Name} (nivel {list[0].Level}) | último: nivel {list[list.Count - 1].Level}");

        Op("Order por daño ↓",
            () => list.Order(Criteria.DanoDesc),
            () => $"1.º {list[0].Name} (daño {list[0].Attack}) | último: daño {list[list.Count - 1].Attack}");

        Op("Order por velocidad ↑",
            () => list.Order(Criteria.VelocidadAsc),
            () => $"1.º {list[0].Name} (vel. {list[0].AtackSpeed:0.##}) | último: vel. {list[list.Count - 1].AtackSpeed:0.##}");

        Op($"Eliminar los primeros {eliminations:N0}",
            () => { for (int i = 0; i < eliminations; i++) list.DeleteIn(0); },
            () => $"Quedan {list.Count:N0} | nuevo primero: {list[0].Name}");

        return ops;
    }
}
