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
    public partial class FormAtualizarAcao : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormAtualizarAcao()
        {
            InitializeComponent();
        }

        private void FormAtualizarAcao_Load(object sender, EventArgs e)
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
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtReferencial.ReadOnly = false;
            mtxtDataInicio.ReadOnly = false;
            mtxtDataFim.ReadOnly = false;
            cmbHorario.Enabled = true;
            txtLocalidade.ReadOnly = false;
            btnAtualizar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string referencial = "", dataInicio = "", dataFim = "", horario = "", localidade = "";
            
            if(ligacao.PesquisarAcao(txtIDAcao.Text, ref referencial, ref dataInicio, ref dataFim, 
                ref horario, ref localidade))
            {
                txtReferencial.Text = referencial;
                mtxtDataInicio.Text = dataInicio;
                mtxtDataFim.Text = dataFim;
                cmbHorario.SelectedItem = horario;
                txtLocalidade.Text = localidade;

                grpBoxPesquisa.Enabled = false;
                AtivarControlos();
                btnAtualizar.Focus();
            }
            else
            {
                MessageBox.Show("Ação não encontrada!");
                txtIDAcao.Text = "";
                txtIDAcao.Focus();
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(ligacao.UpdateAcao(txtIDAcao.Text, txtReferencial.Text,
                DateTime.Parse(mtxtDataInicio.Text).ToString("yyyy-MM-dd"),
                DateTime.Parse(mtxtDataFim.Text).ToString("yyyy-MM-dd"),
                cmbHorario.Text, txtLocalidade.Text))
            {
                MessageBox.Show("Ação atualizada com sucesso!");
                btnCancelar_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Erro na atualização da Ação!");
            }
        }

        private bool VerificarCampos()
        {
            txtIDAcao.Text = Geral.TirarEspacos(txtIDAcao.Text);
            if (txtIDAcao.Text.Length < 6)
            {
                MessageBox.Show("Erro no campo ID!");
                txtIDAcao.Focus();
                return false;
            }

            txtReferencial.Text = Geral.TirarEspacos(txtReferencial.Text);
            if (txtReferencial.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo Referencial!");
                txtReferencial.Focus();
                return false;
            }

            if (mtxtDataInicio.Text.Length != 10 || Geral.CheckDate(mtxtDataInicio.Text) == false)
            {
                MessageBox.Show("Erro no campo Data de Início!");
                mtxtDataInicio.Focus();
                return false;
            }

            if (mtxtDataFim.Text.Length != 10 || Geral.CheckDate(mtxtDataFim.Text) == false)
            {
                MessageBox.Show("Erro no campo Data de Fim!");
                mtxtDataFim.Focus();
                return false;
            }

            if (cmbHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Horário!");
                cmbHorario.Focus();
                return false;
            }


            txtLocalidade.Text = Geral.TirarEspacos(txtLocalidade.Text);
            if (txtLocalidade.Text.Length < 2 || txtLocalidade.Text.Length > 100)
            {
                MessageBox.Show("Erro no campo Localidade!");
                txtLocalidade.Focus();
                return false;
            }

            return true;
        }

        public void LimparCampos()
        {
            txtIDAcao.Text = string.Empty;
            txtIDAcao.Focus();
            txtReferencial.Text = string.Empty;
            mtxtDataInicio.Clear();
            mtxtDataFim.Clear();
            cmbHorario.SelectedIndex = 0;
            txtLocalidade.Text= string.Empty;
            DesativarControlos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            grpBoxPesquisa.Enabled = true;
        }
    }
}
