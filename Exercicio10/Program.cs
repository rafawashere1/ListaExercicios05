namespace ListaExercicios05.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaPonderada = new();

            Console.WriteLine("-------- Calculadora de Média Ponderada --------\n");

            mediaPonderada.nota1 = 7;
            mediaPonderada.peso1 = 2;
            mediaPonderada.nota2 = 10;
            mediaPonderada.peso2 = 1;
            mediaPonderada.nota3 = 8;
            mediaPonderada.peso3 = 1;

            Console.WriteLine($">> A média ponderada é: {mediaPonderada.CalcularMediaPonderada()}");
        }
    }
}