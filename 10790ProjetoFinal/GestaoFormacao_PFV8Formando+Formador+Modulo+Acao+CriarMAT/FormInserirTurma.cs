using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GestaoFormacao_PF
{
    public partial class FormInserirTurma : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirTurma()
        {
            InitializeComponent();
        }

        private void FormInserirTurma_Load(object sender, EventArgs e)
        {
            nuIDRegisto.Value = ligacao.DevolveUltimoIDTurma();
            nuIDRegisto.ReadOnly = true;
            nUDIDModulo.ReadOnly = true;
            txtIDAcao.ReadOnly = true;
            nUDIDFormando.ReadOnly = true;

            ligacao.PreencherCmbModulo(ref cmbModulo);
            ligacao.PreencherCmbAcao(ref cmbAcao);
            ligacao.PreencherCmbFormando(ref cmbFormando);
        }

        private bool VerificarCampos()
        {
            if (nUDIDModulo.Value == 0)
            {
                MessageBox.Show("Erro na escolha do Módulo!");
                cmbModulo.Focus();
                return false;
            }

            if (txtIDAcao.Text.Length == 0)
            {
                MessageBox.Show("Erro na escolha da Ação!");
                cmbAcao.Focus();
                return false;
            }
            if (nUDIDFormando.Value == 0)
            {
                MessageBox.Show("Erro na escolha do Formando!");
                cmbFormando.Focus();
                return false;
            }

            return true;
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idModulo = cmbModulo.Text.Substring(cmbModulo.Text.LastIndexOf(' ') + 1);
            if (idModulo.Length > 0)
            {
                nUDIDModulo.Value = int.Parse(idModulo);
            }
            else
            {
                MessageBox.Show("Lista de Módulos Vazia!");
            }
        }

        private void cmbAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idAcao = cmbAcao.Text.Substring(cmbAcao.Text.LastIndexOf(' ') + 1);
            if (idAcao.Length > 0)
            {
                txtIDAcao.Text = idAcao;
            }
            else
            {
                MessageBox.Show("Lista de Ações Vazia!");
            }
        }

        private void cmbFormando_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idFormando = cmbFormando.Text.Substring(cmbFormando.Text.LastIndexOf(' ') + 1);
            if (idFormando.Length > 0)
            {
                nUDIDFormando.Value = int.Parse(idFormando);
            }
            else
            {
                MessageBox.Show("Lista de Formandos Vazia!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.InserirTurma(nuIDRegisto.Value.ToString(), nUDIDModulo.Value.ToString(),
                    txtIDAcao.Text, nUDIDFormando.Value.ToString()))
                {
                    MessageBox.Show("Inserido com sucesso!");
                    LimparCampos();
                    cmbModulo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na gravação do registo!");
                }
            }
        }

        private void LimparCampos()
        {
            nuIDRegisto.Value = ligacao.DevolveUltimoIDTurma();

            cmbModulo.Text = "";
            cmbAcao.Text = "";
            cmbFormando.Text = "";

            nUDIDModulo.Value = 0;
            txtIDAcao.Text = string.Empty;
            nUDIDFormando.Value = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
