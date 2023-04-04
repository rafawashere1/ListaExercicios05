namespace ListaExercicios05.Exercicio04
{
    internal class ConsumoGasolina
    {
        public double kmInicial;
        public double kmFinal;
        public double gasolina;

        public double CalcularConsumo()
        {
            return (kmInicial - kmFinal) / gasolina;
        }
    }
}
