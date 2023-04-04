namespace ListaExercicios05.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new();

            Console.WriteLine("-------- Calculador de Salário --------\n");

            salario.salarioBase = 2000;
            salario.vendas = 100000;
            salario.percentual = 5;


            Console.WriteLine($">> O salário do funcionário é: {salario.CalcularSalario()}");
        }
    }
}