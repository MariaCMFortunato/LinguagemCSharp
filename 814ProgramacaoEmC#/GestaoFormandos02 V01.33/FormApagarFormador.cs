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
    public partial class FormApagarFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormApagarFormador()
        {
            InitializeComponent();
        }

        private void FormApagarFormador_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            nudID.Focus();
        }

        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            mtxtNIF.ReadOnly = true;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;
            cmbArea.Enabled = false;
            cmbUtilizador.Enabled = false;
            btnEliminar.Enabled = false;

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
            btnEliminar.Enabled = true;
            btnEliminar.Focus();
        }

        public void LimparCampos()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            mtxtNIF.Text = string.Empty;
            mtxtDataNascimento.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbArea.SelectedIndex = 0;
            cmbUtilizador.SelectedIndex = 0;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpBoxPesquisa.Enabled = true;
            LimparCampos();
            nudID.Focus();
            DesativarControlos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registo com o ID " + nudID.Value.ToString() + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteFormador(nudID.Value.ToString()))
                {
                    MessageBox.Show("Registo apagado!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar o resgisto!");
                }
            }
        }
    }
}
