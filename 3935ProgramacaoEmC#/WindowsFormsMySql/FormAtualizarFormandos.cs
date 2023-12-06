using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySql
{
    public partial class FormAtualizarFormandos : Form
    {
        DBConnect dBConnect = new DBConnect();
        public FormAtualizarFormandos()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormandos_Load(object sender, EventArgs e)
        {
            //groupBox3.Enabled = false; 
            DesativarControlos();
            btnAtualizar.Enabled = false;
        }
        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            txtIban.ReadOnly = true;
            rbFeminino.Enabled = false;
            rbMasculino.Enabled = false;
            rbOutro.Enabled = false;
            mtxtDataNasc.ReadOnly = true;

        }

        private void AtivarControlos()
        {
            txtNome.ReadOnly = false;
            txtMorada.ReadOnly = false;
            mtxtContacto.ReadOnly = false;
            txtIban.ReadOnly = false;
            rbFeminino.Enabled = true;
            rbMasculino.Enabled = true;
            rbOutro.Enabled = true;
            mtxtDataNasc.ReadOnly = false;

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "";
            char genero = ' ';

            if (dBConnect.PesquisaFormando(nudId.Value.ToString(), ref nome, ref morada,
                    ref contacto, ref iban, ref genero, ref data_nascimento))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                txtIban.Text = iban;
                if (genero == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else if (genero == 'F')
                {
                    rbFeminino.Checked = true;
                }
                else if (genero == 'O')
                {
                    rbOutro.Checked = true;
                }
                mtxtDataNasc.Text = data_nascimento;
                AtivarControlos();
                groupBox1.Enabled = false;
                btnAtualizar.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Formando não encontrado!");
            }
                        
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (dBConnect.Update(nudId.Value.ToString(), txtNome.Text, txtMorada.Text,
                    mtxtContacto.Text, txtIban.Text, Genero(),
                    DateTime.Parse(mtxtDataNasc.Text).ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Atualizou com sucesso!");
                    //Limpar();
                    //txtNome.Focus();
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização!");
                }
            }
        }

        void Limpar()
        {
            nudId.Value = 0;
            txtNome.Text = "";
            txtMorada.Clear();
            mtxtContacto.Text = string.Empty;
            txtIban.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            mtxtDataNasc.Clear();
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
        
            if (txtNome.Text.Length < 2)
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
         
            if (Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Sexo!");
                rbFeminino.Focus();
                return false;
            }

            if (mtxtDataNasc.Text.Length != 10 || Geral.CheckDate(mtxtDataNasc.Text) == false)
            {

                MessageBox.Show("Erro no campo Data de Nascimento!");
                mtxtDataNasc.Focus();
                return false;
            }

            return true;
        }

        private char Genero()
        {
            char genero = 'T';

            if (rbFeminino.Checked)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAtualizar.Enabled = false;
            Limpar();
            DesativarControlos();
            nudId.Focus();

        }
    }
}
