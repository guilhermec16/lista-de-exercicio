internal class Program
{
    private static void Main(string[] args)
    {
        double maca;
        double preco;
        double total;

        Console.WriteLine("Quantas Maçãs você irá levar??");
        maca = double.Parse(Console.ReadLine());

        if (maca < 12)
        {
            total = maca * 1.30;
        }

        else {
            total = maca * 1;
        }

        Console.WriteLine("Custo Total da compra: R$" + total);
    }
}