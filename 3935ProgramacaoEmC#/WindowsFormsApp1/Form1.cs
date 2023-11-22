using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("O Governo pode cair hoje!", "*** ÚLTIMA HORA ****");
            MessageBox.Show("Apenas o botão OK", "Argumento button", MessageBoxButtons.OK);
            MessageBox.Show("Botões  OK e Cancel", "Argumento button", MessageBoxButtons.OKCancel);
            MessageBox.Show("Botões  Abort, Retry e Ignore", "Argumento button", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Botões  Yes, No e Cancel", "Argumento button", MessageBoxButtons.YesNoCancel);
            MessageBox.Show("Botões  Yes e No", "Argumento button", MessageBoxButtons.YesNo);
            MessageBox.Show("Botões  Retry e Cancel", "Argumento button", MessageBoxButtons.RetryCancel);
            MessageBox.Show("Botões  Yes e No com botão por defeito", "Argumento button", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            MessageBox.Show("Icon Error.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Icon Question.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show("Icon Exclamation.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show("Icon Information.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Icon Warning.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Icon Stop.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("Icon Asterisk.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Icon Hand.", "Argumento icon", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            DialogResult resposta;
            resposta = MessageBox.Show("Fechar a aplicação?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("Escolheu o botão " + resposta.ToString() + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
