using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0, fatorial = 1;

            Console.WriteLine("\n\n**** CALCULAR O FATORIAL DE UM NÚMERO ***");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Indique um numero:  ");
            numero = double.Parse(Console.ReadLine());

            for (double i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("Fatorial: " + fatorial);

            Console.ReadKey();


        }
    }
}
