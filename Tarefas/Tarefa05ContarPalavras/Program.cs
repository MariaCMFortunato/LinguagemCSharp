using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpression;
using System.Threading.Tasks;

namespace Tarefa05ContarPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = null, novaFrase = null;
            int palavras = 0;
            Console.WriteLine("Escreva uma frase: ");
			
			frase = Console.ReadLine();
			
			frase = frase.Trim();	
			frase = Regex.Replace(frase, @"\s+", " ");
			//frase = Regex.Replace(frase, "\\s+", " ");
			
            novaFrase = frase.Replace(" ", "");

            palavras = frase.Length - novaFrase.Length + 1;
			if(palavras != 1){
				Console.WriteLine("A frase que escreveu tem  " + palavras + " palavras.");
			}
			else {
				Console.WriteLine("Não escreveu uma frase!");
			}
            
            Console.ReadKey();

			frase = Regex.Replace(frase, @"\s+", " ");

        }
    }
}
