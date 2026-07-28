using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
        double basee;
        double altura;
        double area;

        Console.WriteLine("Informe a base do retângulo:");
        basee = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a altura do retângulo:");
        altura = double.Parse(Console.ReadLine());

        area = basee * altura;

        Console.WriteLine("Sua área é de: " + area);
    }
}