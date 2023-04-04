namespace ListaExercicios05.Exercicio08
{
    internal class LataDeOleo
    {
        public int raio;
        public double altura;

        public double CalcularVolume()
        {
            return Math.Round(3.14 * raio * raio * altura, 2);
        }
    }
}
