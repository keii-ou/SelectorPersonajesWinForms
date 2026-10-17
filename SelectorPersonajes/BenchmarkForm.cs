namespace SelectorPersonajes;

public partial class BenchmarkForm : Form
{
    private readonly List<Persona> DataBase;

    public BenchmarkForm() : this(new List<Persona>()) { }

    public BenchmarkForm(List<Persona> dataBase)
    {
        InitializeComponent();

        DataBase = dataBase;
        lblState.Text = $"Se generarán personajes a partir de los {DataBase.Count} actuales. Pulsa «Execute benchmark».";
        lblVerification.Text = "";
    }

    private async void btnEjecutar_Click(object? sender, EventArgs e)
    {
        btnExecute.Enabled = false;
        nudQuantity.Enabled = false;
        nudRepetitions.Enabled = false;
        dgvResults.Rows.Clear();
        lblVerification.Text = "";
        lblState.Text = "Preparando datos…";

        int quantity = (int)nudQuantity.Value;
        int repetitions = (int)nudRepetitions.Value; 

        void Progress(string message)
        {
            try
            {
                if (IsHandleCreated && !IsDisposed)
                    BeginInvoke(new Action(() => lblState.Text = message));
            }
            catch { /* el formulario se cerró durante la ejecución */ }
        }

        try
        {
            var result = await Task.Run(() => Benchmark.Execute(DataBase, quantity, repetitions, Progress));
            Mostrar(result);
        }
        catch (Exception ex)
        {
            lblState.Text = "Error al ejecutar el benchmark.";
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnExecute.Enabled = true;
            nudQuantity.Enabled = true;
            nudRepetitions.Enabled = true;
        }
    }

    private void Mostrar(BenchmarkResults r)
    {
        var types = Enum.GetValues<ListType>();

        lblState.Text =
            $"{r.Quantity:N0} personajes (derivados de {r.PersonasBases}) · promedio de {r.Repetitions} repeticiones · verde = más rápido";

        for (int i = 0; i < r.Operations.Length; i++)
        {
            var values = types.Select(t => r.Time[t][i]).ToArray();
            int fila = dgvResults.Rows.Add(r.Operations[i], Fmt(values[0]), Fmt(values[1]), Fmt(values[2]), r.Details[i]);
            Highlight(fila, values);
        }

        var totals = types.Select(t => r.Time[t].Sum()).ToArray();
        int rowTotal = dgvResults.Rows.Add("TOTAL", Fmt(totals[0]), Fmt(totals[1]), Fmt(totals[2]), "");
        dgvResults.Rows[rowTotal].DefaultCellStyle.Font = new Font(dgvResults.Font, FontStyle.Bold);
        Highlight(rowTotal, totals);

        dgvResults.ClearSelection();

        lblVerification.ForeColor = r.Coinciden ? Color.DarkGreen : Color.DarkRed;
        lblVerification.Text = r.Coinciden
            ? "Las tres listas produjeron exactamente los mismos resultados."
            : "Los resultados difieren entre listas (revisar).";
    }

    private static string Fmt(double ms) => ms.ToString("N3");

    private void Highlight(int fila, double[] valores)
    {
        double minimo = valores.Min();
        for (int k = 0; k < valores.Length; k++)
        {
            if (valores[k] == minimo)
            {
                var celda = dgvResults.Rows[fila].Cells[k + 1];
                celda.Style.BackColor = Color.LightGreen;
                celda.Style.ForeColor = Color.Black;
            }
        }
    }
}
