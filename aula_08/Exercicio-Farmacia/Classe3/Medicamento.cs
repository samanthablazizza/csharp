using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Farmacia.Classe3
{
    public class Medicamento : ClasseFarmacia
    {
        private string tipo = string.Empty;
        private string laboratorio = string.Empty;

        public Medicamento (string nome, int unidade, string farmResponsavel, string funcionarioCaixa, string funcionarioBalcao, string tipo, string laboratorio) 
            : base(nome, unidade, farmResponsavel, funcionarioCaixa, funcionarioBalcao)
        {
            this.tipo = tipo;
            this.laboratorio = laboratorio;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string GetLaboratorio()
        {
            return laboratorio;
        }
        public void SetLaboratorio(string laboratorio)
        {
            this.laboratorio = laboratorio;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Tipo de medicamento:  {this.tipo}");
            Console.WriteLine($"Laboratório:  {this.laboratorio}");
        }

    }
}
