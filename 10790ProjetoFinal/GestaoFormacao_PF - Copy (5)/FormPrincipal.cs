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
        FormInserirModulo formInserirModulo = new FormInserirModulo();
        FormAtualizarModulo formAtualizarModulo = new FormAtualizarModulo();
        FormApagarModulo formApagarModulo = new FormApagarModulo();
        FormListarModulos formListarModulos = new FormListarModulos();
        FormInserirAcao formInserirAcao = new FormInserirAcao();
        FormAtualizarAcao formAtualizarAcao = new FormAtualizarAcao();


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

        private void criarMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirModulo.IsDisposed)
            {
                formInserirModulo = new FormInserirModulo();
            }
            formInserirModulo.MdiParent = this;
            formInserirModulo.StartPosition = FormStartPosition.Manual;
            formInserirModulo.Location = new Point((this.ClientSize.Width - formInserirModulo.Width) / 2, (this.Height - formInserirModulo.Height) / 2);
            formInserirModulo.Show();
            formInserirModulo.Activate();
        }

        private void atualizarMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarModulo.IsDisposed)
            {
                formAtualizarModulo = new FormAtualizarModulo();
            }
            formAtualizarModulo.MdiParent = this;
            formAtualizarModulo.StartPosition = FormStartPosition.Manual;
            formAtualizarModulo.Location = new Point((this.ClientSize.Width - formAtualizarModulo.Width) / 2, (this.Height - formAtualizarModulo.Height) / 2);
            formAtualizarModulo.Show();
            formAtualizarModulo.Activate();
        }

        private void apagarMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarModulo.IsDisposed)
            {
                formApagarModulo = new FormApagarModulo();
            }
            formApagarModulo.MdiParent = this;
            formApagarModulo.StartPosition = FormStartPosition.Manual;
            formApagarModulo.Location = new Point((this.ClientSize.Width - formApagarModulo.Width) / 2, (this.Height - formApagarModulo.Height) / 2);
            formApagarModulo.Show();
            formApagarModulo.Activate();
        }

        private void listarMódulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarModulos.IsDisposed)
            {
                formListarModulos = new FormListarModulos();
            }
            formListarModulos.MdiParent = this;
            formListarModulos.StartPosition = FormStartPosition.Manual;
            formListarModulos.Location = new Point((this.ClientSize.Width - formListarModulos.Width) / 2, (this.Height - formListarModulos.Height) / 2);
            formListarModulos.Show();
            formListarModulos.Activate();
        }

        private void criarAçãoFomaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirAcao.IsDisposed)
            {
                formInserirAcao = new FormInserirAcao();
            }
            formInserirAcao.MdiParent = this;
            formInserirAcao.StartPosition = FormStartPosition.Manual;
            formInserirAcao.Location = new Point((this.ClientSize.Width - formInserirAcao.Width) / 2, (this.Height - formInserirAcao.Height) / 2);
            formInserirAcao.Show();
            formInserirAcao.Activate();
        }

        private void atualizarAçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarAcao.IsDisposed)
            {
                formAtualizarAcao = new FormAtualizarAcao();
            }
            formAtualizarAcao.MdiParent = this;
            formAtualizarAcao.StartPosition = FormStartPosition.Manual;
            formAtualizarAcao.Location = new Point((this.ClientSize.Width - formAtualizarAcao.Width) / 2, (this.Height - formAtualizarAcao.Height) / 2);
            formAtualizarAcao.Show();
            formAtualizarAcao.Activate();
        }
    }
}
