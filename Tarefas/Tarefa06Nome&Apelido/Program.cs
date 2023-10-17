using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa06Nome_Apelido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto = null;
            string[] separacao = null;

            Console.WriteLine("Escreva o seu nome completo: ");
            nomeCompleto= Console.ReadLine();

            separacao = nomeCompleto.Split(' ');
            Console.WriteLine("Nome: " + separacao[0]);
            Console.WriteLine("Apelido: " + separacao[separacao.Length - 1]);

            Console.ReadKey();
        }
    }
}
