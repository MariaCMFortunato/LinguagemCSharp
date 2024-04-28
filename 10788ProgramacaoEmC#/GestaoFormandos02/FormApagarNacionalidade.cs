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
    public partial class FormApagarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormApagarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormApagarNacionalidade_Load(object sender, EventArgs e)
        {
            cmbNacionalidade.Focus();
            txtAlf2.ReadOnly = true;
            txtNacionalidade.ReadOnly = true;
            btnEliminar.Enabled = false;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnEliminar.Enabled = false;
        }

        public void LimparCampos()
        {
            cmbNacionalidade.Focus();
            txtAlf2.Text = string.Empty;
            txtNacionalidade.Text = string.Empty ;

        }

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
