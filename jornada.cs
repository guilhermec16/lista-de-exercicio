internal class Program
{
    private static void Main(string[] args)
    {
        double extra;
        double horasTrabalhadas;
        double total;
        double salarioHora;

        Console.WriteLine("Quantas Horas você trabalha no mês??");
        horasTrabalhadas = double.Parse(Console.ReadLine());

        Console.WriteLine("Quanto você recebe por horas??");
        salarioHora = double.Parse(Console.ReadLine());

        if (horasTrabalhadas > 160)
        {
            total = (160 * salarioHora) + ((horasTrabalhadas - 160) * salarioHora * 1.5);
        }

        else { 
          total = salarioHora * horasTrabalhadas;
        }

        Console.WriteLine("Salário total: R$" + total);

    }
}