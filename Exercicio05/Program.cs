namespace ListaExercicios05.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new();

            Console.WriteLine("-------- Calculador de Volume de Esfera --------\n");

            esfera.raio = 5;

            Console.WriteLine($">> O volume da sua esfera é: {esfera.CalcularVolume()}");
        }
    }
}