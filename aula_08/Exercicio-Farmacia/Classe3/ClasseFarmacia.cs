using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Farmacia.Classe3
{
    public class ClasseFarmacia
    {
        /*Atributos*/
        private string nome = string.Empty;
        private int unidade;
        private string farmResponsavel = string.Empty;
        private string funcionarioCaixa = string.Empty;
        private string funcionarioBalcao = string.Empty;

        /*Método Construtor*/
        public ClasseFarmacia(string nome, int unidade, string farmResponsavel, string funcionarioCaixa, string funcionarioBalcao)
        {
            this.nome = nome;
            this.unidade = unidade;
            this.farmResponsavel = farmResponsavel;
            this.funcionarioCaixa = funcionarioCaixa;
            this.funcionarioBalcao= funcionarioBalcao;
        }
        /*Método Construtor*/
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetUnidade()
        {
            return unidade;
        }

        public void SetUnidade(int unidade)
        {
            this.unidade = unidade;
        }

        public string GetFarmResponsavel()
        {
            return farmResponsavel;
        }
        public void SetFarmResponsavel(string farmResponsavel)
        {
            this.farmResponsavel = farmResponsavel;
        }

        public string GetFuncionarioCaixa()
        {
            return funcionarioCaixa;
        }
        public void SetFuncionarioCaixa(string funcionarioCaixa)
        {
            this.funcionarioCaixa = funcionarioCaixa;
        }

        public string GetFuncionarioBalcao()
        {
            return funcionarioBalcao;
        }
        public void SetFuncionarioBalcao(string funcionarioBalcao)
        {
            this.funcionarioBalcao = funcionarioBalcao;
        }
        public virtual void Visualizar()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                                                          ");
            Console.WriteLine($"Nome da Farmácia: {this.nome}");
            Console.WriteLine($"Unidade: {this.unidade}");
            Console.WriteLine($"Farmacêutico(a) responsável: {this.farmResponsavel}");
            Console.WriteLine($"Funcionário(a) do Caixa: {this.funcionarioCaixa}");
            Console.WriteLine($"Funcionário(a) do Balcão: {this.funcionarioBalcao}");
            Console.WriteLine("                                                          ");
            Console.WriteLine("**********************************************************");


        }
    }
}
