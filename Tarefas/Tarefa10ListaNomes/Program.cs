using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa10ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] Nomes = {"Ana", "António", "Beatriz", "Joana","Raul","Vitória" };
            int X = 4;

            ImpressaoNomes(Nomes, X);
            Console.WriteLine("Selecionamos os " + X + " primeiros nomes de uma lista de " + Nomes.Length);

            Console.WriteLine("Prima qualquer tecla para continuar ...");
            Console.ReadKey();

        }
        public static void ImpressaoNomes(String[] lista, int num)//podia ser private
        {
                    
            for(int i = 0; i <= num;i++)
            { 
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("");


            foreach(String s in lista)
            {
                Console.WriteLine(s);
                num--;
                if(num == 0)
                {
                    break;
                } 
            }
        }    
    }


}

