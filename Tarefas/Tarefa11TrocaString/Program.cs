using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa11TrocaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X1, Y1;

            Console.Write("Digite o valor da primeira variável (X): ");
            X1 = Console.ReadLine();

            Console.Write("Digite o valor da primeira variável (Y): ");
            Y1 = Console.ReadLine();

            Troca(ref X1, ref Y1);

            Console.WriteLine("X = " + X1);
            Console.WriteLine("Y = " + Y1);
            Console.WriteLine("");
            Console.WriteLine("Prima qualquer tecla para continuar ...");
            Console.ReadKey();
        }
        private static void Troca( ref string S1, ref string S2)
        {
            string aux;
            aux = S1;
            S1 = S2;
            S2 = aux;
        }
    }
}
