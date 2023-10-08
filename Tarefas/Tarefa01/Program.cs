using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 0, comprimento = 0, area = 0;

            Console.WriteLine("\n\n**** CALCULAR A ÁREA DE UM RETÂNGULO ***");
            Console.WriteLine("----------------------------------------");
            Console.Write("Indique a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Indique o comp+rimento do retângulo: ");
            comprimento = double.Parse(Console.ReadLine());

            area = altura * comprimento;
            Console.WriteLine("Área do Retângulo: " + area.ToString("0.00"));
            Console.ReadKey(); 

        }
    }
}
