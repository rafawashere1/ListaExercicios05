namespace ListaExercicios05.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new();

            Console.WriteLine("-------- Calculador de Média Harmônica --------\n");

            mediaHarmonica.nota1 = 7;
            mediaHarmonica.nota2 = 10;
            mediaHarmonica.nota3 = 5;

            Console.WriteLine($">> A Média Harmônica das notas do aluno é: {mediaHarmonica.CalcularMediaHarmonica()}");
        }
    }
}