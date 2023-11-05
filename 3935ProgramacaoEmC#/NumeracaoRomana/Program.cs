using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeracaoRomana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, unidades, dezenas;
            string numString, romano1, romano2;

            Console.Write("Introduza um valor entre 1 e 99: ");
            do
            {
                numero = int.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 99);
            numString = numero.ToString("00");
            dezenas = int.Parse(numString.Substring(0, 1));
            unidades = int.Parse(numString.Substring(1, 1));
            switch (dezenas)
            {
                case 1:
                    romano1 = "X";
                    break;
                case 2:
                    romano1 = "XX";
                    break;
                case 3:
                    romano1 = "XXX";
                    break;
                case 4:
                    romano1 = "XL";
                    break;
                case 5:
                    romano1 = "L";
                    break;
                case 6:
                    romano1 = "LX";
                    break;
                case 7:
                    romano1 = "LXX";
                    break;
                case 8:
                    romano1 = "LXXX";
                    break;
                case 9:
                    romano1 = "XC";
                    break;
                default:
                    romano1 = "";
                    break;
            }

            switch (unidades)
            {
                case 1:
                    romano2 = "I";
                    break;
                case 2:
                    romano2 = "II";
                    break;
                case 3:
                    romano2 = "III";
                    break;
                case 4:
                    romano2 = "IV";
                    break;
                case 5:
                    romano2 = "V";
                    break;
                case 6:
                    romano2 = "VI";
                    break;
                case 7:
                    romano2 = "VII";
                    break;
                case 8:
                    romano2 = "VII";
                    break;
                case 9:
                    romano2 = "IX";
                    break;
                default:
                    romano2 = "";
                    break;
            }
            Console.WriteLine("Numero em romano: " +  romano1 + romano2);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
