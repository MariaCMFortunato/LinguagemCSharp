using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySql
{   
    public partial class FormPrincipal : Form
    {
        FormInserirFormandos formInserirFormandos = new FormInserirFormandos();
        FormAtualizarFormandos formAtualizarFormandos = new FormAtualizarFormandos();
        FormListarFormandos formListarFormandos = new FormListarFormandos();
        FormApagarFormando formApagarFormando = new FormApagarFormando();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormandos.IsDisposed)// se o formulário foi destruido ou já não consegue associar
            {
                formInserirFormandos = new FormInserirFormandos();//instancia de novo
            }
            formInserirFormandos.MdiParent = this;
            formInserirFormandos.StartPosition = FormStartPosition.Manual;
            formInserirFormandos.Location = new Point((this.ClientSize.Width - formInserirFormandos.Width) / 2, (this.ClientSize.Height - formInserirFormandos.Height) / 4);
            formInserirFormandos.Show();
            formInserirFormandos.Activate();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormandos.IsDisposed)// se o formulário foi destruido ou já não consegue associar
            {
                formAtualizarFormandos = new FormAtualizarFormandos();//instancia de novo
            }
            formAtualizarFormandos.MdiParent = this;
            formAtualizarFormandos.StartPosition = FormStartPosition.Manual;
            formAtualizarFormandos.Location = new Point((this.ClientSize.Width - formAtualizarFormandos.Width) / 2, (this.ClientSize.Height - formAtualizarFormandos.Height) / 4);
            formAtualizarFormandos.Show();
            formAtualizarFormandos.Activate();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarFormandos.IsDisposed)// se o formulário foi destruido ou já não consegue associar
            {
                formListarFormandos = new FormListarFormandos();//instancia de novo
            }
            formListarFormandos.MdiParent = this;
            formListarFormandos.StartPosition = FormStartPosition.Manual;
            formListarFormandos.Location = new Point((this.ClientSize.Width - formListarFormandos.Width) / 2, (this.ClientSize.Height - formListarFormandos.Height) / 4);
            formListarFormandos.Show();
            formListarFormandos.Activate();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormando.IsDisposed)// se o formulário foi destruido ou já não consegue associar
            {
                formApagarFormando = new FormApagarFormando();//instancia de novo
            }
            formApagarFormando.MdiParent = this;
            formApagarFormando.StartPosition = FormStartPosition.Manual;
            formApagarFormando.Location = new Point((this.ClientSize.Width - formApagarFormando.Width) / 2, (this.ClientSize.Height - formApagarFormando.Height) / 4);
            formApagarFormando.Show();
            formApagarFormando.Activate();
        }
    }
}
