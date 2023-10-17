using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa04Hipotenusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cateto1 = 0, cateto2 = 0, hipotenusa = 0;
            Console.WriteLine("\n\n**** CALCULAR A HIPOTENUSA DE UM TRIÂNGULO RETÂNGULO ***");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Indique a medida do primeiro cateto: ");
            cateto1 = double.Parse(Console.ReadLine());
            Console.Write("Indique a medida do segundo cateto: ");
            cateto2 = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
            Console.WriteLine(""); 
            Console.WriteLine("Cateto A: " + cateto1.ToString("0.00"));
            Console.WriteLine("Cateto B: " + cateto2.ToString("0.00"));
            Console.WriteLine("Hipotenusa: " + hipotenusa.ToString("0.00"));
            Console.ReadKey();

        }
    }
}
