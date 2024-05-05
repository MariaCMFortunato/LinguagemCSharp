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
    public partial class FormAtualizarTurma : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormAtualizarTurma()
        {
            InitializeComponent();
        }

        private void FormAtualizarTurma_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            cmbFormando.Focus();
            ligacao.PreencherCmbFormando(ref cmbFormando);
        }

        private void DesativarControlos()
        {
            nuIDRegisto.Value = 0;
            nuIDRegisto.ReadOnly = true;
            nUDIDModulo.ReadOnly = true;
            txtIDAcao.ReadOnly = true;
            nUDIDFormando.ReadOnly = true;
            cmbModulo.Enabled = false;
            cmbAcao.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            nuIDRegisto.ReadOnly = false;
            nUDIDModulo.ReadOnly = false;
            txtIDAcao.ReadOnly = false;
            nUDIDFormando.ReadOnly = false;
            cmbModulo.Enabled = true;
            cmbAcao.Enabled = true;
            btnAtualizar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string acao = "", modulo = "", registo = "";
            
           
            if(ligacao.PesquisarTurma2(nUDIDFormando.Value.ToString(), ref modulo, ref acao, ref registo))
            {
                nUDIDModulo.Value = int.Parse(modulo);
                ligacao.PreencherCmbModulo(ref cmbModulo);
                txtIDAcao.Text = acao;
                ligacao.PreencherCmbAcao(ref cmbAcao);
                nuIDRegisto.Value = int.Parse(registo);
                

                grpBoxPesquisa.Enabled = false;
                btnAtualizar.Focus();
                AtivarControlos ();


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

        private bool VerificarCampos()
        {
            if (nUDIDFormando.Value == 0)
            {
                MessageBox.Show("Erro na escolha do Formando!");
                cmbFormando.Focus();
                return false;
            }

            return true;
        }


    }
}
