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
    public partial class FormListarFormandos : Form
    {
        DBConnect DBConnect = new DBConnect();
        public FormListarFormandos()
        {
            InitializeComponent();
        }

        private void FormListarFormandos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns.Add("codID", "ID");
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("iban", "IBAN");
            dataGridView1.Columns.Add("datanascimento", "Data nasc.");
            dataGridView1.Columns.Add("genero", "Genero");
            rbTodos.Checked = true;

            DBConnect.PreencherDataGridView(ref dataGridView1, ' ');
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.Rows.Count.ToString();

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DBConnect.PreencherDataGridView(ref dataGridView1, Genero());
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.Rows.Count.ToString();
        }
        private char Genero()
        {
            char genero = 'T';
            if (rbFeminino.Checked)
            {
                genero = 'F';
            }
            else if (rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if (rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }
    }
}
