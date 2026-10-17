namespace SelectorPersonajes;

public class Persona
{
    public static readonly string[] EspeciesBase =
        ["Humano", "Mago", "Caballero", "Arquero", "Elfo", "Enano", "Orco"];

    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public int Attack { get; set; }
    public double AtackSpeed { get; set; }
    public int Level { get; set; }
    public string? ImagePath { get; set; }
    public double Dps => Attack * AtackSpeed;

    public Persona() { }

    public Persona(string name, string species, int attack, double attackSpeed, int level)
    {
        Name = name;
        Species = species;
        Attack = attack;
        AtackSpeed = attackSpeed;
        Level = level;
    }

    public void CopyFrom(Persona otro)
    {
        Name = otro.Name;
        Species = otro.Species;
        Attack = otro.Attack;
        AtackSpeed = otro.AtackSpeed;
        Level = otro.Level;
        ImagePath = otro.ImagePath;
    }

    public static List<Persona> Default() =>
    [
        new("Arthur", "Caballero", 45, 1.2, 12) { ImagePath = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\knight_wbg.jpg" },
        new("Merlín", "Mago", 70, 0.8, 20) { ImagePath = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Wizars.png" },
        new ("Azriel", "Arquera", 38, 2.5, 15) { ImagePath = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Archer.png" },
        new("Thorin", "Enano", 55, 1.0, 18) { ImagePath = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Duende.png" },
        new("Arlene", "Humana", 25, 1.5, 5) { ImagePath = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\human_wbg.jpg" },
    ];
}
