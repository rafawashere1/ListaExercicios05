namespace ListaExercicios05.Exercicio09
{
    internal class MediaHarmonica
    {
        public double nota1;
        public double nota2;
        public double nota3;

        public double CalcularMediaHarmonica()
        {
            return Math.Round(3 / (1 / nota1 + 1 / nota2 + 1 / nota3));
        }
    }
}
