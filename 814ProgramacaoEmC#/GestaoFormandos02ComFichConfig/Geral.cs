using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    internal class Geral
    {
        public static string ipserver = "";
        public static string portaserver = "";
        public static string TirarEspacos(string texto)
        {
            //texto = texto.Trim();
            texto = Regex.Replace(texto.Trim(), @"\s+", " ");
            return texto;
        }
        public static void TirarEspacos(ref TextBox caixTexto)
        {
            //texto = texto.Trim();
            caixTexto.Text = Regex.Replace(caixTexto.Text.Trim(), @"\s+", " ");
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

        public static bool ValidarIPv4(string ipString)
        {
            if (ipString.Count(c => c == '.') != 3)
            {
                return false;
            }

            IPAddress address;
            return IPAddress.TryParse(ipString, out address);
        }

    }
}
