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
    public partial class FormInserirArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormInserirArea()
        {
            InitializeComponent();
        }

        private void FormInserirArea_Load(object sender, EventArgs e)
        {
            nudID.Value = ligacao.DevolveUltimoIDArea();
        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtArea.Text = Geral.TirarEspacos(txtArea.Text);
            if (txtArea.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo Area!");
                txtArea.Focus();
                return false;
            }
            return true;
        }

        public void LimparCampos()
        {
            nudID.Value = ligacao.DevolveUltimoIDArea();
            txtArea.Text = string.Empty;
            txtArea.Focus();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (ligacao.InserirArea(nudID.Value.ToString(), txtArea.Text))
                {
                    MessageBox.Show("Inserida com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro na gravação do registo!");
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
