using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa15ClassSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.Write("Salário Bruto: ");
            salario.salarioBruto = double.Parse(Console.ReadLine());

            salario.salarioLiquido = salario.CalcularSalarioLiquido();

            Console.WriteLine("Líquido: " + (salario.salarioLiquido).ToString("0.00"));

            Console.ReadKey();
        }

        public class Salario
        {
            public double salarioBruto = 0, salarioLiquido = 0;

            public double CalcularSalarioLiquido()
            {

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
                return salarioLiquido;
            }
         };
    }
}
