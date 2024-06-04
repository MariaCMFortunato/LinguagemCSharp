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
    public partial class FormAtualizarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormAtualizarArea()
        {
            InitializeComponent();
        }

        private void FormAtualizarArea_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtArea.ReadOnly = true;
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtArea.ReadOnly = false;
            btnAtualizar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string area = "";
            if(ligacao.PesquisaArea(nudID.Value.ToString(), ref area)) 
            {
                txtArea.Text = area;
                grpBoxPesquisa.Enabled = false;
                AtivarControlos();
                btnAtualizar.Focus();
            }
            else
            {
                MessageBox.Show("Área não encontrada!");
                nudID.Value = 0;
                nudID.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.UpdateArea(nudID.Value.ToString(), txtArea.Text))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtArea.Text = Geral.TirarEspacos(txtArea.Text);
            if (txtArea.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo área!");
                txtArea.Focus();
                return false;
            }
            return true;
        }

        public void LimparCampos()
        {
            nudID.Value = 0;
            txtArea.Text = string.Empty;
            nudID.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpBoxPesquisa.Enabled = true;
            DesativarControlos();
            LimparCampos();
            nudID.Focus();
        }
    }
}
