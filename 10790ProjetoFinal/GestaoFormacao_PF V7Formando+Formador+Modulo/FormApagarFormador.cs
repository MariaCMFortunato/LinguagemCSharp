using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormacao_PF
{
    public partial class FormApagarFormador : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormApagarFormador()
        {
            InitializeComponent();
        }

        private void FormApagarFormador_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            nUDIDFormador.Focus();
        }

        private void DesativarControlos()
        {
            txtNIF.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtLocalidade.ReadOnly = true;
            cmbArea.Enabled = false;
            txtCertificado.ReadOnly = true;
            btnApagar.Enabled = false;
        }

        private void AtivarControlos()
        {
            grpBoxPesquisa.Enabled = false;
            txtNIF.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLocalidade.ReadOnly = false;
            cmbArea.Enabled = true;
            txtCertificado.ReadOnly = false;
            btnApagar.Enabled = true;
        }

        public void LimparCampos()
        {
            nUDIDFormador.Value = 0;
            txtNIF.Text = "";
            txtNome.Text = "";
            txtLocalidade.Text = "";
            cmbArea.SelectedIndex = 0;
            txtCertificado.Text = "";
            DesativarControlos();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nif = "", nome = "", localidade = "", area = "", certificado = "";

            if (ligacao.PesquisarFormador(nUDIDFormador.Value.ToString(), ref nif, ref nome, ref localidade, ref area, ref certificado))
            {
                txtNIF.Text = nif;
                txtNome.Text = nome;
                txtLocalidade.Text = localidade;
                cmbArea.SelectedItem = area;
                txtCertificado.Text = certificado;
                grpBoxPesquisa.Enabled = true;
                btnApagar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formador não encontrado!");
                nUDIDFormador.Value = 0;
                nUDIDFormador.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesativarControlos();
            grpBoxPesquisa.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registo com o ID " + nUDIDFormador.Value.ToString() + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.ApagarFormador(nUDIDFormador.Value.ToString()))
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
