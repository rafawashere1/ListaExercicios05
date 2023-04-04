namespace ListaExercicios05.Exercicio01
{
    internal class CaixaRetangular
    {
        public int altura;
        public int cumprimento;
        public int largura;

        public decimal CalcularVolume()
        {
            return altura * cumprimento * largura;
        }
    }
}
