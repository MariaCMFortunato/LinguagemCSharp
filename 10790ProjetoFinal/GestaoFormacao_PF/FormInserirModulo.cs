using MySqlX.XDevAPI.Common;
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
    public partial class FormInserirModulo : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormInserirModulo()
        {
            InitializeComponent();
        }

        private void FormInserirModulo_Load(object sender, EventArgs e)
        {

        }

        private bool VerificarCampos()
        {
            if (nUDIDModulo.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nUDIDModulo.Focus();
                return false;
            }

            txtDescricao.Text = Geral.TirarEspacos(txtDescricao.Text);
            if (txtDescricao.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Descrição!");
                txtDescricao.Focus();
                return false;
            }

            if (txtCHoraria.Text.Length != 2)
            {
                MessageBox.Show("Erro no campo Carga Horária!");
                txtCHoraria.Focus();
                return false;
            }

            if (txtReferencial.Text.Length != 6)
            {
                MessageBox.Show("Erro no campo Referencial!");
                txtReferencial.Focus();
                return false;
            }

            if (!int.TryParse(txtNivel.Text, out int nRet))
            {
                MessageBox.Show("Erro no campo Nível!");
                txtNivel.Focus();
                return false;
            }
            return true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (ligacao.InserirModulo(nUDIDModulo.Value.ToString(), txtDescricao.Text, txtCHoraria.Text,
                    txtReferencial.Text, txtNivel.Text))
                {
                    MessageBox.Show("Modulo criado com sucesso!");
                    LimparCampos();
                    nUDIDModulo.Focus();
                }
            }
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
            nUDIDModulo.Value = 0;
            txtDescricao.Text = "";
            txtCHoraria.Text = "";
            txtReferencial.Text = "";
            txtNivel.Text = "";
        }
    }
}
