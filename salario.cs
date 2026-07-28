internal class Program
{
    private static void Main(string[] args)
    {
        double salarioNovo;
        double salario;
        double percentual;
        double aumento;

        Console.WriteLine("Qual seu salario atual?");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual seu percentual de reajuste?");
        percentual = double.Parse(Console.ReadLine());

        aumento = salario * (percentual / 100);

        salarioNovo = salario + aumento;

        Console.WriteLine("O novo salário será de: R$" + salarioNovo);

    }
}
