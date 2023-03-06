internal class Program
{
    static double CalculaPorcentagem(double precoGasolina, double precoAlcool)
    {
        return (precoAlcool * 100) / precoGasolina;
    }
    private static void Main(string[] args)
    {
        double pA, pG, p;

        Console.WriteLine("Informe o preço do alcool: ");
        pA = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o preço da gasolina: ");
        pG = double.Parse(Console.ReadLine());

        p = CalculaPorcentagem(pA, pG);

        if (p >= 72) Console.WriteLine("Gasolina é melhor!");
        else Console.WriteLine("Alcool é melhor");

    }
}