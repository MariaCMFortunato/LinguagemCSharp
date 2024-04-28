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
    public partial class FormAtualizarFormador : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormAtualizarFormador()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormador_Load(object sender, EventArgs e)
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
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            grpBoxPesquisa.Enabled = false;
            txtNIF.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLocalidade.ReadOnly = false;
            cmbArea.Enabled = true;
            txtCertificado.ReadOnly = false;
            btnAtualizar.Enabled = true;
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

        private bool VerificarCampos()
        {
            if (nUDIDFormador.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nUDIDFormador.Focus();
                return false;
            }

            if (txtNIF.Text.Length != 9)
            {
                MessageBox.Show("Erro no campo NIF!");
                txtNIF.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            //Geral.TirarEspacos(ref txtNome);
            if (txtNome.Text.Length < 2 || txtNome.Text.Length > 100)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtLocalidade.Text = Geral.TirarEspacos(txtLocalidade.Text);
            if (txtLocalidade.Text.Length < 2 || txtLocalidade.Text.Length > 100)
            {
                MessageBox.Show("Erro no campo Localidade!");
                txtLocalidade.Focus();
                return false;
            }

            if (cmbArea.SelectedIndex.Equals(-1) || cmbArea.SelectedIndex.Equals(0))
            {
                MessageBox.Show("Erro no campo Área!");
                cmbArea.Focus();
                return false;
            }

            if (txtCertificado.Text.Length == 0 || txtCertificado.Text.Length > 20)
            {
                MessageBox.Show("Erro no campoCertificado!");
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nif = "", nome = "", localidade = "", area = "", certificado = "";

            if(ligacao.PesquisarFormador(nUDIDFormador.Value.ToString(), ref nif, ref nome, ref localidade, ref area, ref certificado))
            {
                txtNIF.Text = nif;
                txtNome.Text = nome;
                txtLocalidade.Text = localidade;
                cmbArea.SelectedItem = area;
                txtCertificado.Text = certificado;
                grpBoxPesquisa.Enabled = true;
                btnAtualizar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formador não encontrado!");
                nUDIDFormador.Value = 0;
                nUDIDFormador.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.UpdateFormador(nUDIDFormador.Value.ToString(), txtNIF.Text, txtNome.Text, 
                    txtLocalidade.Text, cmbArea.Text, txtCertificado.Text))
                {
                    MessageBox.Show("Ficha de Formador atualizada com sucesso!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização da ficha!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesativarControlos();
            grpBoxPesquisa.Enabled = true;
        }
    }

}