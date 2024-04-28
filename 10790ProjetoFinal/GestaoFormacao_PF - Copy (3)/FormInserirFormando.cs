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
    public partial class FormInserirFormando : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirFormando()
        {
            InitializeComponent();
        }

        private void FormInserirFormando_Load(object sender, EventArgs e)
        {
            nUDIDFormando.Value = ligacao.DevolveUltimoIDFormando();
            nUDIDFormando.ReadOnly = true;
        }

        private bool VerificarCampos()
        {
            if(nUDIDFormando.Value == 0)
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                int sitEmprego = 0;
                sitEmprego = cmbSitEmprego.SelectedIndex;

                //MessageBox.Show("Situação no emprego: " + sitEmprego);

                if(ligacao.InserirFormando(nUDIDFormando.Value.ToString(), txtNIF.Text, txtNome.Text, txtLocalidade.Text, 
                    DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), sitEmprego.ToString())) 
                {
                    MessageBox.Show("Ficha de Formando criada com sucesso!");
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
            nUDIDFormando.Value = ligacao.DevolveUltimoIDFormando();
            txtNIF.Text = "";
            txtNome.Text = "";
            txtLocalidade.Text = "";
            mtxtDataNascimento.Clear();
            cmbSitEmprego.SelectedIndex = 0;

        }
    }
}
