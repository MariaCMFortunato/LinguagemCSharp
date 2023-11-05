using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa13ContarNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conta = 0;
            string nome;

            Console.Write("Digite um nome ou ZZZ para terminar: ");
            nome = Console.ReadLine().ToUpper();

            while (nome != "ZZZ")
            {
                conta = ContaIniciais(nome, conta);

                Console.Write("Digite um nome ou ZZZ para terminar: ");
                nome = Console.ReadLine().ToUpper();

            }
            Console.WriteLine("Há " + conta + " nome(s) começados(s) por A, B, C");

            Console.WriteLine("Prima qualquer tecla para continuar ...");
            Console.ReadKey();
        }
        public static int ContaIniciais(string nome, int conta)
        {
            if (nome.StartsWith("A") || nome.StartsWith("B") || nome.StartsWith("C"))
            {
                conta++;
            }
            return conta;
        }
    }
}
