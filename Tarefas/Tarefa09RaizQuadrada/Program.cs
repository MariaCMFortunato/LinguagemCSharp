using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa09RaizQuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Min = 0, Max = 0;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("IMPRIMIR RAIZES QUADRADAS DE UM INTERVALO");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Indique o limite inferior do intervalo: ");
            Min = int.Parse(Console.ReadLine());
            Console.Write("Indique o limite superior do intervalo: ");
            Max = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            RaizesQuad(Min, Max);
            Console.WriteLine("");
            Console.ReadKey();
        }

        private static void RaizesQuad(int Inf, int Sup)
        {
            for (int i = Inf; i <= Sup; i++)
            {
                Console.WriteLine("Raiz Quadrada de " + i + " = " + Math.Sqrt(i));
            }
        }
    };
}
