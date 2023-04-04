namespace ListaExercicios05.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorFahrenheit conversor = new();

            Console.WriteLine("-------- Conversor de Fahrenheit para Celsius --------\n");

            conversor.fahrenheit = 40;

            Console.WriteLine($">> A temperatura em Celsius é: {conversor.ConverterTemperatura()}");
        }
    }
}