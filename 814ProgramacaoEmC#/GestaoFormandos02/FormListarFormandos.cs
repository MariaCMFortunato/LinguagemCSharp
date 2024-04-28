using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    public partial class FormListarFormandos : Form
    {
        DBConnect ligacao = new DBConnect();
        
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
            dataGridView1.Columns.Add("contacto", "Contacto");
            dataGridView1.Columns.Add("genero", "Género");
            dataGridView1.Columns.Add("nacionalidade", "Nacionalidade");

            ligacao.PreencherDataGridViewFormando(ref dataGridView1);

            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);

            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();

            rbtnTodos.Checked = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            ligacao.PreencherDataGridViewFormando(ref dataGridView1);
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();
            rbtnTodos.Checked = true ;
            txtNome.Text = "";
            cmbNacionalidade.Text = "";

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Formandos.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message + "\nImpossível de apagar o ficheiro!");
                        }
                    }
                    //if (!fileError == true)
                    //if (fileError == false)
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfPTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 3;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfPTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value.ToString());
                                }
                            }

                            //using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))

                            FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                            //{
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfPTable);
                            pdfDoc.Close();
                            stream.Close();
                            //}

                            MessageBox.Show("Imprimiu com sucesso!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não existe registos!");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
          
          string id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);
            

            ligacao.PreencherDataGridViewFormando(ref dataGridView1, Genero(), txtNome.Text, id_nacionalidade);

            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();
        }

        private char Genero()
        {
            char genero = 'T';
            if(rbtnFeminino.Checked) 
            {
                genero = 'F';
            }

            if(rbtnMasculino.Checked)
            {
                genero = 'M';
            }

            if(rbtnOutro.Checked) 
            {
                genero = 'O';
            }

            return genero;
        }
    }
}
