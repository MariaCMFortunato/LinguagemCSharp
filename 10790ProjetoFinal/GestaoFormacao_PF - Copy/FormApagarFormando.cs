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
    public partial class FormApagarFormando : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormApagarFormando()
        {
            InitializeComponent();
        }

        private void FormApagarFormando_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtNIF.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtLocalidade.ReadOnly = true;
            mtxtDataNascimento.ReadOnly = true;
            cmbSitEmprego.Enabled = false;
            btnApagar.Enabled = false;
        }

        private void AtivarControlos()
        {
            grpBoxPesquisa.Enabled = false;
            txtNIF.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLocalidade.ReadOnly = false;
            mtxtDataNascimento.ReadOnly = false;
            cmbSitEmprego.Enabled = true;
            btnApagar.Enabled = true;
        }

        public void LimparCampos()
        {
            nUDIDFormando.Value = 0;
            txtNIF.Text = "";
            txtNome.Text = "";
            txtLocalidade.Text = "";
            mtxtDataNascimento.Clear();
            cmbSitEmprego.SelectedIndex = 0;
            DesativarControlos();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nif = "", nome = "", localidade = "", dataNasc = "", sitEmprego = "";

            if (ligacao.PesquisarFormando(nUDIDFormando.Value.ToString(), ref nif, ref nome, ref localidade, ref dataNasc,
                ref sitEmprego))
            {
                txtNIF.Text = nif;
                txtNome.Text = nome;
                txtLocalidade.Text = localidade;
                mtxtDataNascimento.Text = dataNasc;
                cmbSitEmprego.SelectedIndex = int.Parse(sitEmprego);

                grpBoxPesquisa.Enabled = false;
                btnApagar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
                nUDIDFormando.Value = 0;
                nUDIDFormando.Focus();
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
            if (MessageBox.Show("Deseja apagar o registo com o ID " + nUDIDFormando.Value.ToString() + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.ApagarFormando(nUDIDFormando.Value.ToString()))
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
