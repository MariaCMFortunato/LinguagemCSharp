using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCentroFormacaoProjFinal
{
    public partial class FormTeste : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormTeste()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ligação: " + ligacao.StatusConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBconnect ligacao = new DBconnect();
            label2.Text = "Nº Total de Registos: " + ligacao.Contar().ToString();

        }
    }
}
