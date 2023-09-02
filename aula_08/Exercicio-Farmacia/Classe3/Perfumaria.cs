using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Farmacia.Classe3
{

    public class Perfumaria : ClasseFarmacia
    {
        private string setor = string.Empty;
        private string fabricante = string.Empty;

        public Perfumaria(string nome, int unidade, string farmResponsavel, string funcionarioCaixa, string funcionarioBalcao, string setor, string fabricante)
            : base(nome, unidade, farmResponsavel, funcionarioCaixa, funcionarioBalcao)
        {
            this.setor = setor;
            this.fabricante = fabricante;
        }
        public string GeSetor()
        {
            return setor;
        }

        public void SetSetor(string setor)
        {
            this.setor = setor;
        }
        public string GetFabricante()
        {
            return fabricante;
        }

        public void SetFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Setor da perfumaria:  {this.setor}");
            Console.WriteLine($"Setor da perfumaria:  {this.fabricante}");
        }
    }
        
}
