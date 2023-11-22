using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa12Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
			/*int.TryParse(Console.ReadLine(), out a); no caso de errro de digitação
			 o programa continua */
            Console.Write("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Maior: " + Comparar.MaiorDe3(A, B, C));
            Console.WriteLine("Menor: " + Comparar.MenorDe3(A, B, C));



            Console.WriteLine("Prima qualquer tecla para continuar ...");
            Console.ReadKey();
        }

        public class Comparar
        {
            public int X = 0, Y = 0, Z = 0;

            public static int MaiorDe3(int X, int Y, int Z)
            {
                if (X < Y)
                {
                    X = Y;
                }
                if (X < Z)
                {
                    X = Z;
                }

                return X;
            }

            public static int MenorDe3(int X, int Y, int Z)
            {
                if (X > Y)
                {
                    X = Y;
                }
                if (X > Z)
                {
                    X = Z;
                }

                return X;
            }


        };
    }
}
