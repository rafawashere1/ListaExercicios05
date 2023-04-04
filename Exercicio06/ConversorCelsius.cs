namespace ListaExercicios05.Exercicio06
{
    internal class ConversorCelsius
    {
        public double celsius;

        public double ConverterTemperatura()
        {
            return Math.Round(celsius * 1.8 + 32, 2);
        }
    }
}
