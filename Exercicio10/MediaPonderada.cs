namespace ListaExercicios05.Exercicio10
{
    internal class MediaPonderada
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double peso1;
        public double peso2;
        public double peso3;

        public double CalcularMediaPonderada()
        {
            return Math.Round((nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3));
        }
    }
}
