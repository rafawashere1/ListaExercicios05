namespace ListaExercicios05.Exercicio03
{
    internal class Cilindro
    {
        public int raio;
        public double altura;

        public double CalcularVolume()
        {
            return Math.Round(Math.PI * Math.Pow(raio, 2) * altura, 2);
        }
    }
}
