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
    public partial class FormInserirFormador : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirFormador()
        {
            InitializeComponent();
        }

        private void FormInserirFormador_Load(object sender, EventArgs e)
        {
            nUDIDFormador.Value = ligacao.DevolveUltimoIDFormador();
            nUDIDFormador.ReadOnly = true;
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
           
            if (cmbArea.SelectedIndex.Equals(-1))
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.InserirFormador(nUDIDFormador.Value.ToString(), txtNIF.Text, txtNome.Text, txtLocalidade.Text, 
                    cmbArea.Text, txtCertificado.Text))
                {
                    MessageBox.Show("Ficha de Formador Criada com sucesso!");
                    LimparCampos();
                    txtNIF.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            nUDIDFormador.Value = ligacao.DevolveUltimoIDFormador();
            txtNIF.Text = "";
            txtNome.Text = "";
            txtLocalidade.Text = "";
            cmbArea.SelectedIndex = 0;
            txtCertificado.Text = "";

        }

    }
}
