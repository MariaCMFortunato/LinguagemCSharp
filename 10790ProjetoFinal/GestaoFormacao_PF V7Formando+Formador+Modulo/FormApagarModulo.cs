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
    public partial class FormApagarModulo : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormApagarModulo()
        {
            InitializeComponent();
        }

        private void FormApagarModulo_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtDescricao.ReadOnly = true;
            txtCHoraria.ReadOnly = true;
            txtReferencial.ReadOnly = true;
            txtNivel.ReadOnly = true;
            btnApagar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtDescricao.ReadOnly = false;
            txtCHoraria.ReadOnly = false;
            txtReferencial.ReadOnly = false;
            txtNivel.ReadOnly = false;
            btnApagar.Enabled = true;
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string descricao = "", cargaHoraria = "", referencial = "", nivel = "";
            
            if (ligacao.PesquisarModulo(nUDIDModulo.Value.ToString(), ref descricao, ref cargaHoraria, ref referencial,
                ref nivel))
            {
                txtDescricao.Text = descricao;
                txtCHoraria.Text = cargaHoraria;
                txtReferencial.Text = referencial.ToString();
                txtReferencial.Text = nivel;

                grpBoxPesquisa.Enabled = false;
                btnApagar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Módulo não encontrado!");
                nUDIDModulo.Value = 0;
                nUDIDModulo.Focus();
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
            if (MessageBox.Show("Deseja apagar o registo com o ID " + nUDIDModulo.Value.ToString() + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.ApagarModulo(nUDIDModulo.Value.ToString()))
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
