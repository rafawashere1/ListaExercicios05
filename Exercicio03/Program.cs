namespace ListaExercicios05.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new();

            Console.WriteLine("-------- Calculador de Volume de Cilindro --------\n");
     
            cilindro.raio = 5;
            cilindro.altura = 7;

            Console.WriteLine($">> O volume do seu cilindro é: {cilindro.CalcularVolume()}");
        }
    }
}