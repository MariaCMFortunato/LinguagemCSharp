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
    public partial class FormApagarAcao : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormApagarAcao()
        {
            InitializeComponent();
        }

        private void FormApagarAcao_Load(object sender, EventArgs e)
        {
            DesativarControlos();
        }

        private void DesativarControlos()
        {
            txtReferencial.ReadOnly = true;
            mtxtDataInicio.ReadOnly = true;
            mtxtDataFim.ReadOnly = true;
            cmbHorario.Enabled = false;
            txtLocalidade.ReadOnly = true;
            btnApagar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtReferencial.ReadOnly = false;
            mtxtDataInicio.ReadOnly = false;
            mtxtDataFim.ReadOnly = false;
            cmbHorario.Enabled = true;
            txtLocalidade.ReadOnly = false;
            btnApagar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string referencial = "", dataInicio = "", dataFim = "", horario = "", localidade = "";

            if (ligacao.PesquisarAcao(txtIDAcao.Text, ref referencial, ref dataInicio, ref dataFim,
                ref horario, ref localidade))
            {
                txtReferencial.Text = referencial;
                mtxtDataInicio.Text = dataInicio;
                mtxtDataFim.Text = dataFim;
                cmbHorario.SelectedItem = horario;
                txtLocalidade.Text = localidade;

                grpBoxPesquisa.Enabled = false;
                AtivarControlos();
                btnApagar.Focus();
            }
            else
            {
                MessageBox.Show("Ação não encontrada!");
                txtIDAcao.Text = "";
                txtIDAcao.Focus();

            }
        }

        public void LimparCampos()
        {
            txtIDAcao.Text = string.Empty;
            txtIDAcao.Focus();
            txtReferencial.Text = string.Empty;
            mtxtDataInicio.Clear();
            mtxtDataFim.Clear();
            cmbHorario.SelectedIndex = 0;
            txtLocalidade.Text = string.Empty;
            DesativarControlos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            grpBoxPesquisa.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registo com o ID " + txtIDAcao.Text + "?", 
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(ligacao.ApagarAcao(txtIDAcao.Text))
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
