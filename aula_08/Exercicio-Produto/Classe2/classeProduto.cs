using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Produto.Classe2
{
    public class classeProduto
    {
        /*Atributos*/
        private string tipo = string.Empty;
        private string processador = string.Empty;
        private string capacidade = string.Empty;
        private string marca = string.Empty;
        private decimal valor;

        /*Método Construtor*/
        public classeProduto(string tipo, string processador, string capacidade, string marca, decimal valor)
        {
            this.tipo = tipo;
            this.processador = processador;
            this.capacidade = capacidade;
            this.marca = marca;
            this.valor = valor;
        }
        /*Método Construtor*/
        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string GetProcessador()
        {
            return processador;
        }

        public void SetProcessador(string processador)
        {
            this.processador = processador;
        }

        public string GetCapacidade()
        {
            return capacidade;
        }
        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }

        public void Visualizar()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                                                          ");
            Console.WriteLine($"Tipo de produto: {this.tipo}");
            Console.WriteLine($"Processador: {this.processador}");
            Console.WriteLine($"Capacidade: {this.capacidade}");
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Valor: " + (this.valor).ToString("C"));
            Console.WriteLine("                                                          ");
            Console.WriteLine("**********************************************************");


        }
    }
}
