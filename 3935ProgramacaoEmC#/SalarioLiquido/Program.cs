using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double bruto, segSocial, irs, liquido; // declaração das variáveis

            // obtenção dos dados
            Console.Write("Salário Bruto: ");

            bruto = double.Parse(Console.ReadLine());

            //Calculos
            segSocial = bruto * .20;

            if (bruto < 500)
            {
                irs = 0;
            }
            else if (bruto >= 500 && bruto < 1000) {
                irs = bruto * 0.12;
            }
            else if (bruto >= 1000 && bruto < 1500)
            {
                irs = bruto * 0.15;
            }
            else
            {
                irs = bruto * .018;
            }
            liquido = bruto - segSocial - irs;

            //Apresentação do resultado
            Console.WriteLine("Líquido: " + liquido.ToString("0.00 €");

            Console.WriteLine("Prima qualquer tecla par sair ...");

            Console.ReadKey();
        }
    }
}
