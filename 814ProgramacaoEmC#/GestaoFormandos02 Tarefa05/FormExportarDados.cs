using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    public partial class FormExportarDados : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormExportarDados()
        {
            InitializeComponent();
        }

        private void FormExportarDados_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboTabelas(ref cmbTabelas);
        }

        private void cmbTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDados.Text = "";
            if(cmbTabelas.SelectedIndex > 0)
            {
                ligacao.PreencherChkLstColunasTabelas(ref chkLstColunas, cmbTabelas.Text);
                ligacao.PreencherComboColunasTabelas(ref cmbCampos, cmbTabelas.Text);
            }
        }

        private void chkLstColunas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportDados_Click(object sender, EventArgs e)
        {
            //chkLstColunas.Items.Count;
            if(chkLstColunas.CheckedItems.Count > 0)
            {
                string[] dados = new string[chkLstColunas.CheckedItems.Count];
                int index = 0;
                foreach (object itemChecked in chkLstColunas.CheckedItems)
                {
                   
                    //MessageBox.Show("Coluna " + itemChecked.ToString());
                    dados[index] = itemChecked.ToString();
                    index++;
                }
                if(cmbCampos.SelectedIndex > 0 && cmbOperadores.SelectedIndex > 0 
                    && txtFiltro.Text.Length > 0)
                {
                    string filtro = cmbCampos.Text + " " + cmbOperadores.Text + " '" + txtFiltro.Text + "' ";
                    ligacao.ExportarRegistosParaTextBox(ref txtDados, dados, cmbTabelas.Text, filtro);
                }
                else
                {
                    ligacao.ExportarRegistosParaTextBox(ref txtDados, dados, cmbTabelas.Text);
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar pelo menos uma coluna!");
                chkLstColunas.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chkLstColunas.Items.Clear();
            cmbTabelas.SelectedIndex = 0;
            txtDados.Clear();
            cmbTabelas.Focus();
            cmbCampos.SelectedIndex = 0;
            cmbOperadores.SelectedIndex = 0;
            txtFiltro.Text = "";
        }

        private void btnExportFich_Click(object sender, EventArgs e)
        {
            if(txtDados.Text.Length > 0)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Title = "Guardar dados para exportação";
                dlg.DefaultExt = "txt";
                dlg.FileName = "dados.txt";
                dlg.Filter = "Ficheiros de texto(*.txt)|*.txt!";
                //Só para ver e gravar ficheiros em txt
                //dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                dlg.InitialDirectory = Geral.App_Path();
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(dlg.FileName, txtDados.Text);

                    if(MessageBox.Show("Deseja abrir a pasta da gravação?",
                        "Exportação de dados",MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                        == DialogResult.Yes)
                    {
                        Process.Start("Explorer.exe", dlg.InitialDirectory);
                        Process.Start(dlg.FileName);
                    }
                }


            }
            else
            {
                MessageBox.Show("Não existem dados para exportação!");
            }

        }
    }
}
