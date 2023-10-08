using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDoisInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Valor 1 ");
            n1 = double.Parse(Console.ReadLine());
            //n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor 2 ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado " + (n1 + n2) / 2);
          
            Console.WriteLine("Raiz Quadrada: " + Math.Sqrt((n1 + n2) / 2));
            Console.ReadLine();
        }
    }
}
