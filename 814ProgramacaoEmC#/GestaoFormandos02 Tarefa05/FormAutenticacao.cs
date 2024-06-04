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
    public partial class FormAutenticacao : Form
    {
        DBConnect ligacao = new DBConnect();
        public string userName = string.Empty;
        public FormAutenticacao()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int nfalhas = 0;
            if(ligacao.ValidateUsersStatus(txtUser.Text, ref nfalhas))
            {
                MessageBox.Show("Utilizador bloqueado! Nº de falhas de autenticação: " + nfalhas + "\n Contacte o Administrador do Sistema.");
                return;
            }

            //if(txtUser.Text == "admin" && txtPW.Text == "1234" )
            //if(ligacao.ValidateUser(txtUser.Text, txtPW.Text, ref userName))
            if (ligacao.ValidateUser2(txtUser.Text, txtPW.Text, ref userName))
            {
                DialogResult = DialogResult.OK;
                txtUser.Focus();
            }
            else
            {
                MessageBox.Show("Erro na autenticação!");
            }
        }

        private void FormAutenticacao_Load(object sender, EventArgs e)
        {
            txtPW.Text = string.Empty;
            txtUser.Text = string.Empty;
            //ControlBox = false;//Impede o fecho da janela - desaparece a cruz
            //AcceptButton = btnLogIn;
            txtUser.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPW.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                btnLogIn_Click(sender, e);
            }
        }
    }
}
