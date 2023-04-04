namespace ListaExercicios05.Exercicio05
{
    internal class Esfera
    {
        public double raio;

        public double CalcularVolume()
        {
           return Math.Round(4.0 * Math.PI * Math.Pow(raio, 3) / 3.0, 2);
        }
    }
}
