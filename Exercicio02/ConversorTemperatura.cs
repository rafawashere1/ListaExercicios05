namespace ListaExercicios05.Exercicio02
{
    internal class ConversorFahrenheit
    {
        public decimal fahrenheit;
        public decimal ConverterTemperatura()
        {
            return Math.Round((fahrenheit - 32) / (decimal)1.8, 1);
        }
    }
}
