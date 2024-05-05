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
    public partial class FormAtualizarModulo : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormAtualizarModulo()
        {
            InitializeComponent();
        }

        private void FormAtualizarModulo_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            nUDIDModulo.Focus();
        }
        private void DesativarControlos()
        {
            txtDescricao.ReadOnly = true;
            txtCHoraria.ReadOnly = true;
            txtReferencial.ReadOnly = true;
            txtNivel.ReadOnly = true;
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtDescricao.ReadOnly = false;
            txtCHoraria.ReadOnly =false;
            txtReferencial.ReadOnly = false;
            txtNivel.ReadOnly =false;
            btnAtualizar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string descricao = "", cargaHoraria = "", referencial = "", nivel = "";

            if(ligacao.PesquisarModulo(nUDIDModulo.Value.ToString(), ref descricao, ref cargaHoraria, ref referencial, 
                ref nivel))
            {
                txtDescricao.Text = descricao;
                txtCHoraria.Text = cargaHoraria;
                txtReferencial.Text = referencial;
                txtNivel.Text = nivel;

                grpBoxPesquisa.Enabled = false;
                btnAtualizar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Módulo não encontrado!");
                nUDIDModulo.Value = 0;
                nUDIDModulo.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.UpdateModulo(nUDIDModulo.Value.ToString(), txtDescricao.Text, txtCHoraria.Text, 
                    txtReferencial.Text, txtNivel.Text))
                {
                    MessageBox.Show("Módulo Atualizado com sucesso!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do módulo!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (nUDIDModulo.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nUDIDModulo.Focus();
                return false;
            }

            txtDescricao.Text = Geral.TirarEspacos(txtDescricao.Text);
            if (txtDescricao.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Descrição!");
                txtDescricao.Focus();
                return false;
            }

            if (txtCHoraria.Text.Length != 2)
            {
                MessageBox.Show("Erro no campo Carga Horária!");
                txtCHoraria.Focus();
                return false;
            }

            txtReferencial.Text = Geral.TirarEspacos(txtReferencial.Text);
            if (txtReferencial.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo Referencial!");
                txtReferencial.Focus();
                return false;
            }

            if (!int.TryParse(txtNivel.Text, out int nRet) && !(txtNivel.Text.Equals(2) || 
                txtNivel.Text.Equals(4) || txtNivel.Text.Equals(5)))
            {
                MessageBox.Show("Erro no campo Nível!");
                txtNivel.Focus();
                return false;
            }

            return true;
        }

        public void LimparCampos()
        {
            nUDIDModulo.Value = 0;
            txtDescricao.Text = "";
            txtCHoraria.Text = "";
            txtReferencial.Text = "";
            txtNivel.Text = "";
            DesativarControlos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            grpBoxPesquisa.Enabled = true;
        }
    }
}
