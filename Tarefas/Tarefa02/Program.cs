using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto = 0,salarioLiquido = 0;

            Console.Write("Salário Bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());

            if (salarioBruto < 500)
            {
                salarioLiquido = salarioBruto * (1 - 0.20);
            }

            else if (salarioBruto < 1000)
            {
                salarioLiquido = salarioBruto * (1 - 0.20 - 0.12);
            }
            else if (salarioBruto < 1000)
            {
                salarioLiquido = salarioBruto * (1 - 0.20 - 0.15);
            }
            else
            {
                salarioLiquido = salarioBruto * (1 - 0.20 - 0.15);
            }

            Console.WriteLine("Líquido: " + (salarioLiquido).ToString("0.00"));

            Console.ReadKey();
        }
    }
}
