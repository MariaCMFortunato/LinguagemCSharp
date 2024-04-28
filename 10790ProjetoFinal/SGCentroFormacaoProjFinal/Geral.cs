using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace SGCentroFormacaoProjFinal
{
    internal class Geral
    {
        //public static void TirarEspacos(ref TextBox caixaTexto)
        //{
        //    caixaTexto.Text = Regex.Replace(caixaTexto.Text.Trim(), @"\s+", " ");
        //}

        public static string TirarEspacos(string texto)
        {
            //texto = texto.Trim();
            texto = Regex.Replace(texto.Trim(), @"\s+", " ");
            return texto;
        }

        public static bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }

            catch
            {
                return false;
            }
        }

    }

}
