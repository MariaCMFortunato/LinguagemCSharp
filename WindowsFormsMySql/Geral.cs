using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsMySql
{
    internal class Geral
    {
        public static string TirarEspacos(string texto)
        {
            texto = texto.Trim();
            texto = Regex.Replace(texto, @"\s+", " ");
            return texto;
        }
        public static bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                //se consegue converter a data está correta
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
