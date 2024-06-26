﻿using iTextSharp.text.pdf;
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

namespace GestaoFormacao_PF
{
    public partial class FormListarAcoes : Form
    {
        DBconnect ligacao = new DBconnect();
        public FormListarAcoes()
        {
            InitializeComponent();
        }

        private void FormListarAcoes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Referencial", "Referencial");
            dataGridView1.Columns.Add("DataInicio", "Data Início");
            dataGridView1.Columns.Add("DataFim", "Data Fim");
            dataGridView1.Columns.Add("Horario", "Horário");
            dataGridView1.Columns.Add("Localidade", "Localidade");

            Cursor.Current = Cursors.WaitCursor;

            ligacao.PreencherDGVAcao(ref dataGridView1);

            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;
            ligacao.PreencherDGVAcao(ref dataGridView1);
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();

            txtReferencial.Text = "";
            cmbHorario.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Acoes.pdf";
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
                MessageBox.Show("Não existem registos!");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;
            ligacao.PreencherDGVAcaoFiltrado(ref dataGridView1, txtReferencial.Text, cmbHorario.SelectedItem.ToString());
            lblRegistos.Text = "Nº de Registos: " + dataGridView1.RowCount.ToString();
        }
    }
}
