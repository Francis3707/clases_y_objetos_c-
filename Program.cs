public class Animales
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public void Info()
    {
        Console.WriteLine($"bienvenido: {Nombre} {Apellido}");
    }

}
public class Program
{
    public static void Main()
    {
        Animales estudiante1 = new Animales();
        estudiante1.Nombre = "Francis";
        estudiante1.Apellido = "Hernandez";
        Auto auto1 = new Auto();
        auto1.Color = "verde";
        auto1.Marca = "hyundai";
        auto1.Frenar();
        estudiante1.Info();
    }
}

public class Auto()
{
      public string Color { get; set; }
    public string Marca { get; set; }
    public void Frenar()
    {
        Console.WriteLine($"su auto es de color: {Color} y marca {Marca}");
    }
  
}