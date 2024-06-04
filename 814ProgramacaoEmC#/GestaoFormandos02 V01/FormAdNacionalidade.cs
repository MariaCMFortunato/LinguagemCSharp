using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    public partial class FormAdNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();

        public FormAdNacionalidade()
        {
            InitializeComponent();
        }

        private void FormAdNacionalidade_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.InserirNacionalidade(txtAlf2.Text, txtNacionalidade.Text))
                {
                    MessageBox.Show("Nacionalidade inserida com sucesso!");
                    LimparCampos();
                    txtAlf2.Focus();
                }
            }
        }
        private bool VerificarCampos()
        {
            txtAlf2.Text = Geral.TirarEspacos(txtAlf2.Text);
            if(txtAlf2.Text.Length != 2) 
            {
                MessageBox.Show("Erro no campo Alf2!");
                txtAlf2.Focus();
                return false;
            }
            txtNacionalidade.Text = Geral.TirarEspacos(txtNacionalidade.Text);
            if (txtNacionalidade.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nacionalidade!");
                txtNacionalidade.Focus();
                return false;
            }

            return true;  
        }

        public void LimparCampos()
        {
            txtAlf2.Text = "";
            txtNacionalidade.Text = "";
        }
    }
}
