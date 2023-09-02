using Exercicio_Farmacia.Classe3;

namespace Exercicio_Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasseFarmacia farmacia = new ClasseFarmacia("BoaSil", 2, "Juscelino Vargas", "Antônio Antunes", "Glória Gloriosa");

            farmacia.Visualizar();
            
           Medicamento med = new Medicamento("Dipirona", "EMS");

            med.Visualizar();

            Perfumaria perf = new Perfumaria("Higiene Pessoal", "Unilever");

            perf.Visualizar();
        }
        
    }
}
/*int opcao;
            Conta c1 = new Conta(123, 10, 1, "Gaspar", 1000000.00M);

            c1.Visualizar();
            c1.Sacar(1000);
            c1.Visualizar();
            c1.Depositar(5000);
            c1.Visualizar();*/