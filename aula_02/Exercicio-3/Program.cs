namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicional, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("Informe seu salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe seu adicional noturno: ");
            adicional = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o valor de suas horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o valor de seus descontos: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicional + (horasExtras * 5) - descontos;
            Console.WriteLine("Seu salário líquido é de: R$" + salarioLiquido);



        }
    }
}