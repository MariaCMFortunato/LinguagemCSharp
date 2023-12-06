using Org.BouncyCastle.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace WindowsFormsMySql
{
    public partial class FormApagarFormando : Form
    {
        DBConnect dBConnect = new DBConnect();

        public FormApagarFormando()
        {
            InitializeComponent();
        }

        private void FormApagarFormando_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            BtnApagar.Enabled = false;
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
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            BtnApagar.Enabled = false;
            Limpar();
            DesativarControlos();
            nudId.Focus();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string pergunta = "Tem a certeza que quer apagar o registo de " + nome + "?";
            DialogResult resposta;
            DialogResult confirma;
            resposta = MessageBox.Show(pergunta, "*** Atenção ***", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           

            if (resposta == DialogResult.Yes)
            {
                confirma = MessageBox.Show("O registo não poderá ser recuperado!", "*** Atenção ***", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
                if (confirma == DialogResult.Yes)
                {
                   if (dBConnect.Delete(nudId.Value.ToString()))
                    {
                        MessageBox.Show("Registo apagado!");
                        btnCancelar_Click(sender, e);
                    }
                }
            }
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
                groupBox1.Enabled = false;
                BtnApagar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
            }

        }
    }
}
