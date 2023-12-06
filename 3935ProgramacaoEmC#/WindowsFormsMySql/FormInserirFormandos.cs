using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySql
{
    public partial class FormInserirFormandos : Form
    {
        DBConnect conn = new DBConnect();
        public FormInserirFormandos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInserirFormandos_Load(object sender, EventArgs e)
        {
            nudId.Value = conn.DevolveUltimoId();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (conn.Insert(nudId.Value.ToString(), txtNome.Text, txtMorada.Text, 
                    mtxtContacto.Text, txtIban.Text, Genero(), 
                    DateTime.Parse(mtxtDataNasc.Text).ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Inseriu com sucesso!");
                    Limpar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na inserção!");
                }
            }
        }

        void Limpar()
        {
            nudId.Value = conn.DevolveUltimoId();
            txtNome.Text = "";
            txtMorada.Clear();
            mtxtContacto.Text = string.Empty;
            txtIban.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            mtxtDataNasc.Clear();
        }

        private char Genero()
        {
            char genero = 'T';
            if(rbFeminino.Checked)
            {
                genero = 'F';
            }
            else if (rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if (rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }
        bool VerificarCampos()//como não tem nada é private
        {
            if (nudId.Value < 0) 
            {
                MessageBox.Show("Erro no campo ID!");
                nudId.Focus();
                return false;
            }
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 2 )
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }

            if (mtxtContacto.Text.Length != 9)
            {
                MessageBox.Show("Erro no campo Contacto!");
                mtxtContacto.Focus();
                return false;
            }

            txtIban.Text = Geral.TirarEspacos(txtIban.Text);
            if (txtIban.Text.Length < 25)
            {
                MessageBox.Show("Erro no campo IBAN!");
                txtIban.Focus();
                return false;
            }
            if(Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Sexo!");
                rbFeminino.Focus();
                return false;
            }

            if(mtxtDataNasc.Text.Length != 10 || Geral.CheckDate(mtxtDataNasc.Text) == false)
            {

                MessageBox.Show("Erro no campo Data de Nascimento!");
                mtxtDataNasc.Focus();
                return false;
            }

            return true;
        }
    }
}
