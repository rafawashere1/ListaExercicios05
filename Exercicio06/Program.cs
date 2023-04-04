namespace ListaExercicios05.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCelsius conversor = new();

            Console.WriteLine("-------- Conversor de Celsius para Fahrenheit --------\n");

            conversor.celsius = 21;

            Console.WriteLine($">> A temperatura em Fahrenheit é: {conversor.ConverterTemperatura()}");
        }
    }
}