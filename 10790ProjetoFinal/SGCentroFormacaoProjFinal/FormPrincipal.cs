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
    public partial class FormPrincipal : Form
    {

        FormFichaGeral formFichaGeral = new FormFichaGeral();
        FormTeste formTeste = new FormTeste();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void criarFichaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formFichaGeral.IsDisposed)
            {
                formFichaGeral = new FormFichaGeral();
            }
            formFichaGeral.MdiParent = this;
            formFichaGeral.StartPosition = FormStartPosition.Manual;
            formFichaGeral.Location = new Point((this.ClientSize.Width - formFichaGeral.Width) / 2, (this.Height - formFichaGeral.Height) / 2);
            formFichaGeral.Show();
            formFichaGeral.Activate();

        }

        private void ligaçãoÀBaseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formTeste.IsDisposed)
            {
                formTeste = new FormTeste();
            }
            formTeste.MdiParent = this;
            formTeste.StartPosition = FormStartPosition.Manual;
            formTeste.Location = new Point((this.ClientSize.Width - formTeste.Width) / 2, (this.Height - formTeste.Height) / 2);
            formTeste.Show();
            formTeste.Activate();
        }
    }
}
