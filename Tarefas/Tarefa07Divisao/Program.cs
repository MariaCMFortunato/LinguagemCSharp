using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa07Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = null;
             string[] divisao = null;
            double dividendo = 0, divisor = 0;
            int resultado = 0;

            Console.WriteLine("Qual o dividendo e o divisor?");
            frase = Console.ReadLine();

            divisao = frase.Split(',');

            dividendo = double.Parse(divisao[0]);
            divisor = double.Parse(divisao[1]);

            resultado = (int)(dividendo / divisor);

            Console.WriteLine("O Resultado da divisao inteira é: " + resultado);

            Console.WriteLine("Fim do programa ...");
            Console.ReadKey();
        }
    }
}
