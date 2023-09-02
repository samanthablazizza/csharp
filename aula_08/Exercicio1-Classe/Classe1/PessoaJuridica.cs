using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Classe.Classe1
{
    public class PessoaJuridica : classeCliente
    {
        private string cnpj = string.Empty;
        private string nomeEmpresa = string.Empty;

        public PessoaJuridica(int matricula, string nome, int idade, string raca, string profissao, string cnpj, string nomeEmpresa)
            : base(matricula, nome, idade, raca, profissao)
        {
            this.cnpj = cnpj;
            this.nomeEmpresa = nomeEmpresa;
        }
        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetNomeEmpresa()
        {
            return nomeEmpresa;
        }

        public void SetNomeEmpresa(string nomeEmpresa)
        {
            this.nomeEmpresa = nomeEmpresa;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ: {this.cnpj}");
            Console.WriteLine($"Nome da empresa: {this.nomeEmpresa}");
        }
    }
}
