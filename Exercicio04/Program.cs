namespace ListaExercicios05.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoGasolina consumo = new();

            Console.WriteLine("-------- Calculadora de Consumo de Combustível --------\n");

            consumo.kmInicial = 50;
            consumo.kmFinal = 10;
            consumo.gasolina = 100;

            Console.WriteLine($">> O seu consumo de combustível foi de: {consumo.CalcularConsumo()}");
        }
    }
}