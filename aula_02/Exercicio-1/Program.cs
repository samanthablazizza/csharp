namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o Salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;
            Console.WriteLine("Seu salário total é de: " +  novoSalario);



        }
    }
}