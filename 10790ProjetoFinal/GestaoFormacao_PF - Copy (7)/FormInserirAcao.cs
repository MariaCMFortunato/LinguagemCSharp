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
    public partial class FormInserirAcao : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirAcao()
        {
            InitializeComponent();
        }

        private void FormInserirAcao_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(ligacao.InserirAcao(txtIDAcao.Text, txtReferencial.Text, 
                    DateTime.Parse(mtxtDataInicio.Text).ToString("yyyy-MM-dd"),
                    DateTime.Parse(mtxtDataFim.Text).ToString("yyyy-MM-dd"),
                    cmbHorario.Text, txtLocalidade.Text)) 
                {
                    MessageBox.Show("Ação criada com sucesso!");
                    LimparCampos();
                    txtIDAcao.Focus();
                }
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

            if(cmbHorario.SelectedIndex == -1) 
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtIDAcao.Text = string.Empty;
            txtReferencial.Text = string.Empty;
            mtxtDataInicio.Clear();
            mtxtDataFim.Clear();
            cmbHorario.SelectedIndex = 0;
            txtLocalidade.Text = "";
        }
    }
}
