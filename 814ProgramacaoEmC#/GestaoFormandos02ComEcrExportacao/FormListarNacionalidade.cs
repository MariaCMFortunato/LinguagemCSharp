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
    public partial class FormListarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormListarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormListarNacionalidade_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("alf2", "Alf2");
            dataGridView1.Columns.Add("nacionalidade", "Nacionalidade");

            ligacao.PreencherDGVNacionalidade (ref dataGridView1);
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
