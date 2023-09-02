using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Classe.Classe1
{
    public class PessoaFisica : classeCliente
    {
        private string cpf = string.Empty;
        private string telefone = string.Empty;

        public PessoaFisica(int matricula, string nome,  int idade, string raca, string profissao, string cpf, string telefone) 
            : base(matricula, nome, idade, raca, profissao)
        {
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CPF: {this.cpf}");
            Console.WriteLine($"Telefone para contato: {this.telefone}");
        }


    }
}
