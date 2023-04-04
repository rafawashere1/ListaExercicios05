namespace ListaExercicios05.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lata = new();

            Console.WriteLine("-------- Calculador de Volume de Lata de Óleo --------\n");

            lata.raio = 5;
            lata.altura = 5;

            Console.WriteLine($">> O volume da sua lata de óleo é: {lata.CalcularVolume()}");
        }
    }
}