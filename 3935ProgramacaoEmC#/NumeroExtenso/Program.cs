using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, centenas = 0, dezenas = 0, unidades = 0;
            string unidadesExtenso = null, dezenasExtenso = null;
            string centenasExtenso = null, numExtenso = null;

            Console.Write("Introduza um número inteiro compreendido entre 0 e 999: ");
            valor = int.Parse(Console.ReadLine());

            centenas = valor / 100;
            dezenas = (valor - centenas * 100) /10;
            unidades = valor - centenas * 100 - dezenas * 10;
            if(centenas == 0)
            {
                centenasExtenso = "";
            }
            if(centenas >= 1)
            {
                centenasExtenso = Conv2(centenas);
            }
            if (dezenas == 0)
            {
                dezenasExtenso = "";
            }
            if (dezenas >= 1)
            {
                dezenasExtenso = Conv3(dezenas);
            }
            if (unidades == 0)
            {
                unidadesExtenso = "";
            }
            if (dezenas >= 1)
            {
                unidadesExtenso = Conv1(unidades);
            }

        }
    }
}
