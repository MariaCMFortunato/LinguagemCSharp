using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    public partial class FormApagarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormApagarArea()
        {
            InitializeComponent();
        }

        private void FormApagarArea_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtArea.ReadOnly = true;
            btnEliminar.Enabled = false;
            nudID.Focus();
        }

        private void AtivarControlos()
        {
            txtArea.ReadOnly = false;
            btnEliminar.Enabled = true;
        }

        public void LimparCampos()
        {
            nudID.Value = 0;
            txtArea.Text = string.Empty;
            nudID.Focus();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string area = "";
            if (ligacao.PesquisaArea(nudID.Value.ToString(), ref area))
            {
                txtArea.Text = area;
                grpBoxPesquisa.Enabled = false;
                AtivarControlos();
                btnEliminar.Focus();
            }
            else
            {
                MessageBox.Show("Área não encontrada!");
                nudID.Value = 0;
                nudID.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpBoxPesquisa.Enabled = true;
            LimparCampos();
            DesativarControlos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registo com o ID " + nudID.Value.ToString() + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteArea(nudID.Value.ToString()))
                {
                    MessageBox.Show("Registo apagado!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar o resgisto!");
                }
            }
        }
    }
}
