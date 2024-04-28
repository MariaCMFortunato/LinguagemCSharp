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
                   
                    MessageBox.Show("Coluna " + itemChecked.ToString());
                    dados[index] = itemChecked.ToString();
                    index++;
                }

                ligacao.ExportarRegistosParaTextBox(ref txtDados, dados, cmbTabelas.Text);
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
        }

        private void btnExportFich_Click(object sender, EventArgs e)
        {

        }
    }
}
