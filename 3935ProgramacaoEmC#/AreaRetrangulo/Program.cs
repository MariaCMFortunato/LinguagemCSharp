using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetrangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            //também poderia ser usado o tipo float, o double seria grande demais
            int comprimento, altura, area;

            //obtenção dos dados
            Console.Write("Comprimento: ");
            comprimento = int.Parse(Console.ReadLine());
            //Pode usar o Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura: ");
            altura = int.Parse(Console.ReadLine());

            area = comprimento * altura;

            //apresentação dos resultados
            Console.WriteLine("Área: " + area);
            if(comprimento == altura)
            {
                Console.WriteLine("Os dados indicados são um quadrado");
            }

            Console.WriteLine("Prima qualquer tecla par sair ...");

            Console.ReadKey();

        }
    }
}
