namespace ListaExercicios05.Exercicio07
{
    internal class Salario
    {
        public decimal salarioBase;
        public decimal vendas;
        public decimal percentual;

        public decimal CalcularSalario()
        {
            return Math.Round(salarioBase + (vendas * (percentual / 100)), 2);
        }
    }
}
