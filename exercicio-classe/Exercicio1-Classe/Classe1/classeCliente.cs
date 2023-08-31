using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Classe.Classe1
{
    public class classeCliente
    {
        /*Atributos*/
        private int matricula;
        private string nome = string.Empty;
        private int idade;
        private string raca = string.Empty;
        private string profissao = string.Empty;

        /*Método Construtor*/
        public classeCliente(int matricula, string nome, int idade, string raca, string profissao)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.idade = idade;
            this.raca = raca;
            this.profissao = profissao;
        }
        /*Método Construtor*/
        public int GetMatricula()
        {
            return matricula;
        }
        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetIdade(string nome)
        {
            this.nome = nome;
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public string GetRaca()
        {
            return raca;
        }
        public void SetRaca(string raca)
        {
            this.raca = raca;
        }
        public string GetProfissao()
        {
            return profissao;
        }
        public void SetProfissao(string profissao)
        {
            this.profissao = profissao;
        }
        public void Visualizar()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                                                          ");
            Console.WriteLine($"Matrícula do cliente: {this.matricula}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Idade: {this.idade} anos");
            Console.WriteLine($"Raça: {this.raca}");
            Console.WriteLine($"Idade: {this.profissao}");
            Console.WriteLine("                                                          ");
            Console.WriteLine("**********************************************************");


        }
    }
}
