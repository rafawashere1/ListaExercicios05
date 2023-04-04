namespace ListaExercicios05.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new();

            Console.WriteLine("-------- Calculador de volume de caixa retangular --------\n");

            caixa.altura = 10;
            caixa.cumprimento = 10;
            caixa.largura = 10;

            Console.WriteLine($">> O volume da caixa retangular é: {caixa.CalcularVolume()}");

        }
    }
}