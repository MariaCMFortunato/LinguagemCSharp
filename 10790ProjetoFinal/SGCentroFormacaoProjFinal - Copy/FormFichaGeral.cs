using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCentroFormacaoProjFinal
{
    public partial class FormFichaGeral : Form
    {
        DBconnect ligacao = new DBconnect();

        public FormFichaGeral()
        {
            InitializeComponent();
        }

        private void FormFichaGeral_Load(object sender, EventArgs e)
        {

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                char estado = 'A';
                string funcao = cmbFuncao.Text.Substring(cmbFuncao.Text.LastIndexOf(" ") + 1);
                string HabLiterarias = cmbHabLiterarias.Text.Substring(cmbHabLiterarias.Text.LastIndexOf(" ") + 1);

                if (ligacao.InserirFicha(txtNIF.Text, txtNISS.Text, txtNome.Text, txtMorada.Text, txtTelemovel.Text, txtEmail.Text,
                DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), mtxtIBAN.Text, funcao, HabLiterarias, estado))
                {
                    MessageBox.Show("Ficha criada com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro na criação da Ficha!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (txtNIF.Text.Length != 9)
            {
                MessageBox.Show("Erro no campo NIF!");
                txtNIF.Focus();
                return false;
            }

            if (txtNISS.Text.Length != 11)
            {
                MessageBox.Show("Erro no campo NISS!");
                txtNISS.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 3  || txtNome.Text.Length > 100 ) 
            {

                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 3 || txtMorada.Text.Length > 100)
            {

                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }


            txtTelemovel.Text=Geral.TirarEspacos(txtTelemovel.Text);
            if (txtTelemovel.Text.Length != 9)
            {
                MessageBox.Show("Erro no campo Telemóvel!");
                txtTelemovel.Focus();
                return false;
            }

            txtEmail.Text = Geral.TirarEspacos(txtEmail.Text);
            if(txtEmail.Text.Length < 7 || txtEmail.Text.Length > 100)
            {
                MessageBox.Show("Erro no campo Email!");
                txtEmail.Focus();
                return false;
            }

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            if (mtxtIBAN.Text.Length != 25)
            {
                MessageBox.Show("Erro no campo IBAN!");
                mtxtIBAN.Focus();
                return false;
            }

            if (cmbFuncao.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Função!");
                cmbFuncao.Focus();
                return false;
            }

            if (cmbHabLiterarias.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Habilitações Literárias!");
                cmbHabLiterarias.Focus();
                return false;
            }

            return true;
        }

        public void LimparCampos()
        {
            txtNIF.Text = string.Empty;
            txtNIF.Focus();
            txtNISS.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMorada.Text = string.Empty;
            txtTelemovel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtxtDataNascimento.Text = "";
            mtxtIBAN.Text = string.Empty;
            cmbFuncao.Text = string.Empty;
            cmbHabLiterarias.Text = string.Empty;
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
