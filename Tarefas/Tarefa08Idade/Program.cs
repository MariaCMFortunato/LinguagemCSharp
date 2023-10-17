using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa08Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Now;
            string dataNasc = null;
            int ano, mes, dia, idade;

            Console.Write("Insira a data de nascimento no formato DD/MM/AAAA: ");

            dataNasc = Console.ReadLine();
            ano = int.Parse(dataNasc.Substring(6, 4));
            mes = int.Parse(dataNasc.Substring(3, 2));
            dia = int.Parse(dataNasc.Substring(0,2));
            
            DateTime Nascimento = new DateTime(ano, mes, dia);
           
            idade = hoje.Year - ano;
            if (hoje.Month < mes) idade--;
            if (hoje.Month == mes && hoje.Day > dia) idade--;

            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Dia da semana: " + Nascimento.DayOfWeek );

            Console.WriteLine("Fim do programa ...");
            Console.ReadKey();
        }
    }
}
