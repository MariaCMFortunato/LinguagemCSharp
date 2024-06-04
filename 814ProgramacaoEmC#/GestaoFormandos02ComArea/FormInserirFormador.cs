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
    public partial class FormInserirFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormInserirFormador()
        {
            InitializeComponent();
        }

        private void FormInserirFormador_Load(object sender, EventArgs e)
        {
            nudID.Value = ligacao.DevolveUltimoIDFormador();
            ligacao.PreencherComboArea(ref cmbArea);
            ligacao.PreencherComboUtilizador(ref cmbUtilizador);
        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            if (mtxtNIF.Text.Length != 9)
            {
                MessageBox.Show("Erro no campo NIF!");
                mtxtNIF.Focus();
                return false;
            }

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            if (cmbArea.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Área!");
                cmbArea.Focus();
                return false;
            }

            if (cmbUtilizador.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Utilizador!");
                cmbUtilizador.Focus();
                return false;
            }
            return true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mtxtDataNascimento.Text = dateTimePicker1.Value.ToShortDateString();
        }

        public void LimparCampos()
        {
            nudID.Value = ligacao.DevolveUltimoID();
            txtNome.Text = string.Empty;
            mtxtNIF.Text = string.Empty;
            mtxtDataNascimento.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbArea.Text = "";
            cmbUtilizador.Text = string.Empty;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string idArea = cmbArea.Text.Substring(cmbArea.Text.LastIndexOf(' ') + 1);
                string idUtilizador = cmbUtilizador.Text.Substring(cmbUtilizador.Text.LastIndexOf(' ') + 1);

                if (ligacao.InserirFormador(nudID.Value.ToString(), txtNome.Text, mtxtNIF.Text, 
                    DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), idArea, idUtilizador))
                {
                    MessageBox.Show("Formador inserido com sucesso!");
                    LimparCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na gravação do registo!");
                }
            }
        }

        private void mtxtDataNascimento_TextChanged_1(object sender, EventArgs e)
        {
            int dia, mes, ano;
            string textoData;
            DateTime data;
            if (mtxtDataNascimento.MaskCompleted)
            {
                textoData = mtxtDataNascimento.Text;
                dia = int.Parse(textoData.Substring(0, 2));
                mes = int.Parse(textoData.Substring(3, 2));
                ano = int.Parse(textoData.Substring(6));

                try
                {
                    data = DateTime.Parse(dia + "-" + mes + "-" + ano);
                    dateTimePicker1.Value = data;
                }
                catch
                {
                    MessageBox.Show("Data incorreta!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtDataNascimento.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
