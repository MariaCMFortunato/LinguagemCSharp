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
    public partial class Form1 : Form
    {
        DBConnect dBConnect = new DBConnect();
        FormInserirFormandos inserirFormandos = new FormInserirFormandos();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nº total de formandos: " + dBConnect.Count());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dBConnect.Insert("11", "Frederico Varandas","Rua do Sporting", "000000000", "PT123456789", 'M', "1979-09-19"))
            {
                MessageBox.Show("Inseriu com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na inserção!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inserirFormandos.IsDisposed)// se o formulário foi destruido ou já não consegue associar
            {
                inserirFormandos = new FormInserirFormandos();//instancia de novo
            }
            inserirFormandos.Show();
            inserirFormandos.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
