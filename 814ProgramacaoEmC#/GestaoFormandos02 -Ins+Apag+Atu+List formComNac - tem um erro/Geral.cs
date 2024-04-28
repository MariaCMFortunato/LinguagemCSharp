﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    internal class Geral
    {
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
    }
}
