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
    public partial class FormAtualizarFormando : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormAtualizarFormando()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormando_Load(object sender, EventArgs e)
        {
            DesativarControlos();

            nUDIDFormando.Focus();
        }


        private void DesativarControlos()
        {
            txtNIF.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtLocalidade.ReadOnly = true;
            mtxtDataNascimento.ReadOnly = true;
            cmbSitEmprego.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            grpBoxPesquisa.Enabled = false;
            txtNIF.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLocalidade.ReadOnly = false;
            mtxtDataNascimento.ReadOnly = false;
            cmbSitEmprego.Enabled = true;
            btnAtualizar.Enabled = true;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nif = "", nome = "", localidade = "", dataNasc = "", sitEmprego = "";

            if (ligacao.PesquisarFormando( nUDIDFormando.Value.ToString(), ref nif, ref nome, ref localidade, ref dataNasc, 
                ref sitEmprego)) 
            {
                txtNIF.Text = nif;
                txtNome.Text = nome;
                txtLocalidade .Text = localidade;
                mtxtDataNascimento.Text = dataNasc;
                cmbSitEmprego.SelectedIndex = int.Parse(sitEmprego);

                grpBoxPesquisa .Enabled = false;
                btnAtualizar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
                nUDIDFormando.Value = 0;
                nUDIDFormando.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos()) 
            {
                //int sitEmprego = 0;
                //sitEmprego = cmbSitEmprego.SelectedIndex;
                if(ligacao.UpdateFormando(nUDIDFormando.Value.ToString(), txtNIF.Text, txtNome.Text, txtLocalidade.Text,
                    DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), cmbSitEmprego.SelectedIndex.ToString()))
                {
                    MessageBox.Show("Ficha de Formando Atualizada com sucesso!");
                    btnCancelar_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Erro na atualização da ficha!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (nUDIDFormando.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nUDIDFormando.Focus();
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

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            if (cmbSitEmprego.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Situação Emprego!");
                cmbSitEmprego.Focus();
                return false;
            }


            return true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            grpBoxPesquisa.Enabled = true;
        }
    }
}
