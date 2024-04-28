using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormacao_PF
{
    public partial class FormListarFormandos : Form
    {
        DBconnect ligacao = new DBconnect();
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
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("NIF", "NIF");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Localidade", "Localidade");
            dataGridView1.Columns.Add("DataNascimento", "Data Nascimento");
            dataGridView1.Columns.Add("SituacaoEmprego", "Situacao Emprego");
 
            ligacao.PreencherDGVFormando(ref dataGridView1);

            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();

        }
    }
}
