using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormacao_PF
{
    public partial class FormPrincipal : Form
    {
        FormTeste formTeste = new FormTeste();
        FormInserirFormando formInserirFormando = new FormInserirFormando();
        FormAtualizarFormando formAtualizarFormando = new FormAtualizarFormando();
        FormApagarFormando formApagarFormando = new FormApagarFormando();
        FormListarFormandos formListarFormandos = new FormListarFormandos();
        FormInserirFormador formInserirFormador = new FormInserirFormador();
        FormAtualizarFormador formAtualizarFormador = new FormAtualizarFormador();
        FormApagarFormador formApagarFormador = new FormApagarFormador();
        FormListarFormadores formListarFormadores = new FormListarFormadores();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void testeDeLigaçãoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void criarFichaFormandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormando.IsDisposed)
            {
                formInserirFormando = new FormInserirFormando();
            }
            formInserirFormando.MdiParent = this;
            formInserirFormando.StartPosition = FormStartPosition.Manual;
            formInserirFormando.Location = new Point((this.ClientSize.Width - formInserirFormando.Width) / 2, (this.Height - formInserirFormando.Height) / 2);
            formInserirFormando.Show();
            formInserirFormando.Activate();
        }

        private void atualizarFichaFormandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormando.IsDisposed)
            {
                formAtualizarFormando = new FormAtualizarFormando();
            }
            formAtualizarFormando.MdiParent = this;
            formAtualizarFormando.StartPosition = FormStartPosition.Manual;
            formAtualizarFormando.Location = new Point((this.ClientSize.Width - formAtualizarFormando.Width) / 2, (this.Height - formAtualizarFormando.Height) / 2);
            formAtualizarFormando.Show();
            formAtualizarFormando.Activate();
        }

        private void apagarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormando.IsDisposed)
            {
                formApagarFormando = new FormApagarFormando();
            }
            formApagarFormando.MdiParent = this;
            formApagarFormando.StartPosition = FormStartPosition.Manual;
            formApagarFormando.Location = new Point((this.ClientSize.Width - formApagarFormando.Width) / 2, (this.Height - formApagarFormando.Height) / 2);
            formApagarFormando.Show();
            formApagarFormando.Activate();
        }

        private void listarFormandosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void criarFichaFormadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormador.IsDisposed)
            {
                formInserirFormador = new FormInserirFormador();
            }
            formInserirFormador.MdiParent = this;
            formInserirFormador.StartPosition = FormStartPosition.Manual;
            formInserirFormador.Location = new Point((this.ClientSize.Width - formInserirFormador.Width) / 2, (this.Height - formInserirFormador.Height) / 2);
            formInserirFormador.Show();
            formInserirFormador.Activate();
        }

        private void atualizarFichaFormadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formAtualizarFormador.IsDisposed)
            {
                formAtualizarFormador = new FormAtualizarFormador();
            }
            formAtualizarFormador.MdiParent = this;
            formAtualizarFormador.StartPosition = FormStartPosition.Manual;
            formAtualizarFormador.Location = new Point((this.ClientSize.Width - formAtualizarFormador.Width) / 2, (this.Height - formAtualizarFormador.Height) / 2);
            formAtualizarFormador.Show();
            formAtualizarFormador.Activate();
        }

        private void apagarFormadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormador.IsDisposed)
            {
                formApagarFormador = new FormApagarFormador();
            }
            formApagarFormador.MdiParent = this;
            formApagarFormador.StartPosition = FormStartPosition.Manual;
            formApagarFormador.Location = new Point((this.ClientSize.Width - formApagarFormador.Width) / 2, (this.Height - formApagarFormador.Height) / 2);
            formApagarFormador.Show();
            formApagarFormador.Activate();
        }

        private void listarFormadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarFormadores.IsDisposed)
            {
                formListarFormadores = new FormListarFormadores();
            }
            formListarFormadores.MdiParent = this;
            formListarFormadores.StartPosition = FormStartPosition.Manual;
            formListarFormadores.Location = new Point((this.ClientSize.Width - formListarFormadores.Width) / 2, (this.Height - formListarFormadores.Height) / 2);
            formListarFormadores.Show();
            formListarFormadores.Activate();
        }
    }
}
