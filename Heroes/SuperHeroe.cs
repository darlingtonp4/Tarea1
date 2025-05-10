public class SuperHeroe
{
    public string? Nombre { get; set; }
    public string? Identidad { get; set; }
    public string? Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder Super { get; set; }
    public SuperHeroe()
    {
        Super = new SuperPoder();
    }
    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Identidad: {Identidad}");
        Console.WriteLine($"Ciudad: {Ciudad}");
        Console.WriteLine($"Puede Volar: {PuedeVolar}");
        Console.WriteLine($"Poder:{Super.Nombre}");
        Console.WriteLine($"Descripcion:{Super.Descripcion}");
        Console.WriteLine($"Nivel:{Super.Nivel}");
    }
}