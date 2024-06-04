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
    public partial class FormAtualizarFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormAtualizarFormador()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormador_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            mtxtNIF.ReadOnly = true;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;
            cmbArea.Enabled = false;
            cmbUtilizador.Enabled = false;
            btnAtualizar.Enabled = false;

            grpBoxPesquisa.Enabled = true;
            ligacao.PreencherComboArea(ref cmbArea);
            ligacao.PreencherComboUtilizador(ref cmbUtilizador);
            nudID.Focus();
        }

        private void AtivarControlos()
        {
            txtNome.ReadOnly = false;
            mtxtNIF.ReadOnly = false;
            mtxtDataNascimento.ReadOnly = false;
            //dateTimePicker1.Visible = false;
            cmbArea.Enabled = true;
            cmbUtilizador.Enabled = true;
            btnAtualizar.Enabled = true;
            btnAtualizar.Focus();
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

            if (cmbArea.SelectedIndex == 0)
            {
                MessageBox.Show("Erro no campo Área!");
                cmbArea.Focus();
                return false;
            }

            if (cmbUtilizador.SelectedIndex == 0)
            {
                MessageBox.Show("Erro no campo Utilizador!");
                cmbUtilizador.Focus();
                return false;
            }
            return true;
        }

        public void LimparCampos()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            mtxtNIF.Text = string.Empty;
            mtxtDataNascimento.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbArea.SelectedIndex = 0;
            cmbUtilizador .SelectedIndex = 0;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", nif = "", dataNascimento = "", idArea = "", idUtilizador = "";

            if (ligacao.PesquisaFormador(nudID.Value.ToString(), ref nome, ref nif, ref dataNascimento,
                ref idArea, ref idUtilizador))
            {
                txtNome.Text = nome;
                mtxtNIF.Text = nif;
                mtxtDataNascimento.Text = dataNascimento;
                cmbArea.Text = ligacao.DevolverArea(idArea);
                cmbUtilizador.Text = ligacao.DevolverUtilizador(idUtilizador);
                grpBoxPesquisa.Enabled = false;
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formador não encontrado!");
                nudID.Value = 0;
                nudID.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string idArea = cmbArea.Text.Substring(cmbArea.Text.LastIndexOf(' ') + 1);
                string idUtilizador = cmbUtilizador.Text.Substring(cmbUtilizador.Text.LastIndexOf(' ') + 1);
                if(ligacao.UpdateFormador(nudID.Value.ToString(), txtNome.Text, mtxtNIF.Text, 
                    DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), idArea, idUtilizador))
                {
                    MessageBox.Show("Formador atualizado com sucesso!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesativarControlos();

            nudID.Focus();
        }
    }
}
