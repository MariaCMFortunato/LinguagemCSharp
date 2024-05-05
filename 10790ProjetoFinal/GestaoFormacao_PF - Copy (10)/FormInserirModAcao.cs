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
    public partial class FormInserirModAcao : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirModAcao()
        {
            InitializeComponent();
        }

        private void FormInserirModAcao_Load(object sender, EventArgs e)
        {
            nuIDRegisto.Value = ligacao.DevolveUltimoIDModAcao();
            nuIDRegisto.ReadOnly = true;
            nUDIDModulo.ReadOnly = true;
            txtIDAcao.ReadOnly = true;
            nUDIDFormador.ReadOnly = true;

            ligacao.PreencherCmbModulo(ref cmbModulo);
            ligacao.PreencherCmbAcao(ref cmbAcao);
            ligacao.PreencherCmbFormador(ref cmbFormador);
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
            if (nUDIDFormador.Value == 0)
            {
                MessageBox.Show("Erro na escolha do Formador!");
                cmbFormador.Focus();
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

        private void cmbFormador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idFormador = cmbFormador.Text.Substring(cmbFormador.Text.LastIndexOf(' ') + 1);
            if (idFormador.Length > 0)
            {
                nUDIDFormador.Value = int.Parse(idFormador);
            }
            else
            {
                MessageBox.Show("Lista de Formadores Vazia!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (VerificarCampos())
            {
                if (ligacao.InserirModAcao(nuIDRegisto.Value.ToString(), nUDIDModulo.Value.ToString(),
                    txtIDAcao.Text, nUDIDFormador.Value.ToString()))
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
            nuIDRegisto.Value = ligacao.DevolveUltimoIDModAcao();

            cmbModulo.Text = "";
            cmbAcao.Text = "";
            cmbFormador.Text = "";

            nUDIDModulo.Value = 0;
            txtIDAcao.Text = string.Empty;
            nUDIDFormador.Value = 0;
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
