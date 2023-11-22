using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa14ClassArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area retang = new Area();

            Console.WriteLine("\n\n**** CALCULAR A ÁREA DE UM RETÂNGULO ***");
            Console.WriteLine("----------------------------------------");
            Console.Write("Indique a altura do retângulo: ");
            retang.altura = float.Parse(Console.ReadLine());
            Console.Write("Indique o comp+rimento do retângulo: ");
            retang.comprimento = float.Parse(Console.ReadLine());

            retang.calcularArea(retang.altura, retang.comprimento);

        }

    }
	class Area
        {
           public float altura = 0, comprimento = 0, area = 0;

            public void calcularArea(float altura, float comprimento)
            {
                area = altura * comprimento;
                Console.WriteLine("Área do Retângulo: " + area.ToString("0.00"));
                Console.ReadKey();
            }
            

        };
}
