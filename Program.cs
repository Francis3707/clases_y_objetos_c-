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
        estudiante1.Info();
    }
}
