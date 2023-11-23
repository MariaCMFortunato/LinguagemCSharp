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
    public partial class Principal : Form
    {
        FormInserirFormandos inserirFormandos = new FormInserirFormandos();
        public Principal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inserirFormandos.
                inserirFormandos = new FormInserirFormandos();
                
            }
            inserirFormandos.MdiParent = this;

            inserirFormandos.Show();
            inserirFormandos.Activate();
        }
    }
}
