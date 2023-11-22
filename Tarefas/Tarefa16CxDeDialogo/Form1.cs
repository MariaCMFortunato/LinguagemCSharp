using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa16CxDeDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("O Governo caiu hoje!", "*** ÚLTIMA HORA ****");

            DialogResult resposta;
            resposta = MessageBox.Show("Irá haver eleições?", "*** RESPONDE: ****", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            while (resposta == DialogResult.No)
            {
                MessageBox.Show("Pensa melhor! Já Falaste com o Presidente da República?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resposta = MessageBox.Show("Irá haver eleições?", "*** RESPONDE: ****", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            MessageBox.Show("Escolheste que vai haver eleições. Vamos a isso ....", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
