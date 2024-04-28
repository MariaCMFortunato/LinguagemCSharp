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
    public partial class FormPrincipal : Form
    {
        FormInserirFormandos formInserirFormandos = new FormInserirFormandos();
        FormApagarFormandos formApagarFormandos = new FormApagarFormandos();
        FormListarFormandos formListarFormandos = new FormListarFormandos();
        FormAdNacionalidade formAdNacionalidade = new FormAdNacionalidade();
        FormApagarNacionalidade formApagarNacionalidade = new FormApagarNacionalidade();
        FormListarNacionalidade formListarNacionalidade = new FormListarNacionalidade ();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormandos.IsDisposed)
            {
                formInserirFormandos = new FormInserirFormandos();
            }
            formInserirFormandos.MdiParent = this;
            formInserirFormandos.StartPosition = FormStartPosition.Manual;
            formInserirFormandos.Location = new Point((this.ClientSize.Width-formInserirFormandos.Width)/2,(this.Height-formInserirFormandos.Height)/2);
            formInserirFormandos.Show();
            formInserirFormandos.Activate();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formApagarFormandos.IsDisposed)
            {
                formApagarFormandos = new FormApagarFormandos();
            }
            formApagarFormandos.MdiParent = this;
            formApagarFormandos.StartPosition = FormStartPosition.Manual;
            formApagarFormandos.Location = new Point((this.ClientSize.Width - formApagarFormandos.Width) / 2, (this.Height - formApagarFormandos.Height) / 2);
            formApagarFormandos.Show();
            formApagarFormandos.Activate();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarFormandos.IsDisposed)
            {
                formListarFormandos = new FormListarFormandos();
            }
            formListarFormandos.MdiParent = this;
            formListarFormandos.StartPosition = FormStartPosition.Manual;
            formListarFormandos.Location = new Point((this.ClientSize.Width - formListarFormandos.Width) / 2, (this.Height - formListarFormandos.Height) / 2);
            formListarFormandos.Show();
            formListarFormandos.Activate();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formAdNacionalidade.IsDisposed)
            {
                formAdNacionalidade = new FormAdNacionalidade();
            }
            formAdNacionalidade.MdiParent = this;
            formAdNacionalidade.StartPosition = FormStartPosition.Manual;
            formAdNacionalidade.Location = new Point((this.ClientSize.Width - formAdNacionalidade.Width) / 2, (this.Height - formAdNacionalidade.Height) / 2);
            formAdNacionalidade.Show();
            formAdNacionalidade.Activate();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formApagarNacionalidade.IsDisposed)
            {
                formApagarNacionalidade = new FormApagarNacionalidade();
            }
            formApagarNacionalidade.MdiParent = this;
            formApagarNacionalidade.StartPosition = FormStartPosition.Manual;
            formApagarNacionalidade.Location = new Point((this.ClientSize.Width - formApagarNacionalidade.Width) / 2, (this.Height - formApagarNacionalidade.Height) / 2);
            formApagarNacionalidade.Show();
            formApagarNacionalidade.Activate();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formListarNacionalidade.IsDisposed)
            {
                formListarNacionalidade = new FormListarNacionalidade();
            }
            formListarNacionalidade.MdiParent = this;
            formListarNacionalidade.StartPosition = FormStartPosition.Manual;
            formListarNacionalidade.Location = new Point((this.ClientSize.Width - formListarNacionalidade.Width) / 2, (this.Height - formListarNacionalidade.Height) / 2);
            formListarNacionalidade.Show();
            formListarNacionalidade.Activate();
        }
    }
}
