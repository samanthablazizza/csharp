﻿using Metodos2.NameSpace01;

namespace Metodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoProtegido();
            MetodoPrivado();

            Classe01.MetodoPublico();
            Classe01.MetodoInternal();
            // Classe01.MetodoProtegido(); só é acessível se houver uma relação de herança
            // Classe01.MetodoPrivado(); só é acessível dentro da classe que foi criado

            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
            //Classe02.MetodoProtegido();
            //Classe02.MetodoPrivado();
        }

        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe Program");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe Program");
        }
        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido - Classe Program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe Program");
        }
    }
}