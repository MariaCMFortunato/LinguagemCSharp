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
    public partial class FormPrincipal : Form
    {
        //FormInserirFormandos formInserirFormandos = new FormInserirFormandos();
        //FormAtualizarFormandos formAtualizarFormandos = new FormAtualizarFormandos();
        //FormApagarFormandos formApagarFormandos = new FormApagarFormandos();
        //FormListarFormandos formListarFormandos = new FormListarFormandos();
        //FormAdNacionalidade formAdNacionalidade = new FormAdNacionalidade();
        //FormApagarNacionalidade formApagarNacionalidade = new FormApagarNacionalidade();
        //FormListarNacionalidade formListarNacionalidade = new FormListarNacionalidade ();
        //FormAutenticacao formAutenticacao = new FormAutenticacao ();


        FormInserirFormandos formInserirFormandos;
        FormAtualizarFormandos formAtualizarFormandos;
        FormApagarFormandos formApagarFormandos;
        FormListarFormandos formListarFormandos;
        FormAdNacionalidade formAdNacionalidade;
        FormApagarNacionalidade formApagarNacionalidade;
        FormListarNacionalidade formListarNacionalidade;
        FormAutenticacao formAutenticacao;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormandos.IsDisposed)
            {
                formInserirFormandos = new FormInserirFormandos();
            }
            formInserirFormandos.MdiParent = this;
            formInserirFormandos.StartPosition = FormStartPosition.Manual;
            formInserirFormandos.Location = new Point((this.ClientSize.Width-formInserirFormandos.Width)/2,(this.Height-formInserirFormandos.Height)/2);
            formInserirFormandos.Show();
            formInserirFormandos.Activate();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formApagarFormandos.IsDisposed)
            {
                formApagarFormandos = new FormApagarFormandos();
            }
            formApagarFormandos.MdiParent = this;
            formApagarFormandos.StartPosition = FormStartPosition.Manual;
            formApagarFormandos.Location = new Point((this.ClientSize.Width - formApagarFormandos.Width) / 2, (this.Height - formApagarFormandos.Height) / 2);
            formApagarFormandos.Show();
            formApagarFormandos.Activate();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarFormandos.IsDisposed)
            {
                formListarFormandos = new FormListarFormandos();
            }
            formListarFormandos.MdiParent = this;
            formListarFormandos.StartPosition = FormStartPosition.Manual;
            formListarFormandos.Location = new Point((this.ClientSize.Width - formListarFormandos.Width) / 2, (this.Height - formListarFormandos.Height) / 2);
            formListarFormandos.Show();
            formListarFormandos.Activate();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formAdNacionalidade.IsDisposed)
            {
                formAdNacionalidade = new FormAdNacionalidade();
            }
            formAdNacionalidade.MdiParent = this;
            formAdNacionalidade.StartPosition = FormStartPosition.Manual;
            formAdNacionalidade.Location = new Point((this.ClientSize.Width - formAdNacionalidade.Width) / 2, (this.Height - formAdNacionalidade.Height) / 2);
            formAdNacionalidade.Show();
            formAdNacionalidade.Activate();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formApagarNacionalidade.IsDisposed)
            {
                formApagarNacionalidade = new FormApagarNacionalidade();
            }
            formApagarNacionalidade.MdiParent = this;
            formApagarNacionalidade.StartPosition = FormStartPosition.Manual;
            formApagarNacionalidade.Location = new Point((this.ClientSize.Width - formApagarNacionalidade.Width) / 2, (this.Height - formApagarNacionalidade.Height) / 2);
            formApagarNacionalidade.Show();
            formApagarNacionalidade.Activate();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formListarNacionalidade.IsDisposed)
            {
                formListarNacionalidade = new FormListarNacionalidade();
            }
            formListarNacionalidade.MdiParent = this;
            formListarNacionalidade.StartPosition = FormStartPosition.Manual;
            formListarNacionalidade.Location = new Point((this.ClientSize.Width - formListarNacionalidade.Width) / 2, (this.Height - formListarNacionalidade.Height) / 2);
            formListarNacionalidade.Show();
            formListarNacionalidade.Activate();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (VerificarFicheiro())
            {
                LerFicheiro();
            }
            
            formInserirFormandos = new FormInserirFormandos();
            formAtualizarFormandos = new FormAtualizarFormandos();
            formApagarFormandos = new FormApagarFormandos();
            formListarFormandos = new FormListarFormandos();
            formAdNacionalidade = new FormAdNacionalidade();
            formApagarNacionalidade = new FormApagarNacionalidade();
            formListarNacionalidade = new FormListarNacionalidade ();
            formAutenticacao = new FormAutenticacao ();

            toolStripLabelUser.Text = "";
            toolStripButtonLogOut.Enabled = false;
            
            formAutenticacao.ShowDialog();//faz com que a janela de autenticação seja a primeira ser exibida
            toolStripLabelUser.Text = "Perfil: " + formAutenticacao.userName;
            toolStripButtonLogOut.Enabled = true;
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja efetuar logout?\nTodas as janelas serão fechadas!", "LogOut",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach(Form frm in this.MdiChildren)
                {
                    frm.Dispose();
                    frm.Close();
                }

                toolStripLabelUser.Text = "";
                toolStripButtonLogOut.Enabled = false;
                formAutenticacao.ShowDialog();
                toolStripLabelUser.Text = "Perfil: " + formAutenticacao.userName;
                toolStripButtonLogOut.Enabled = true;
                
            }
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormandos.IsDisposed)
            {
                formAtualizarFormandos = new FormAtualizarFormandos();
            }
            formAtualizarFormandos.MdiParent = this;
            formAtualizarFormandos.StartPosition = FormStartPosition.Manual;
            formAtualizarFormandos.Location = new Point((this.ClientSize.Width - formAtualizarFormandos.Width) / 2, (this.Height - formAtualizarFormandos.Height) / 2);
            formAtualizarFormandos.Show();
            formAtualizarFormandos.Activate();
        }

        private bool VerificarFicheiro()
        {
            bool flag = true;
            string path = AppDomain.CurrentDomain.BaseDirectory +"config.txt";

            try
            {
                if(!File.Exists(path)) 
                {
                    //vamos gravar os dados do servidor e a porta
                    FormConfig formConfig = new FormConfig();
                    DialogResult result = formConfig.ShowDialog();//recebe a indicação de ok do formulário
                    if (result == DialogResult.OK)
                    {
                        // criar ficheiro para escrita
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(formConfig.mtxtIP.Text.Replace(",", "."));
                            sw.WriteLine(formConfig.mtxtPorta.Text);
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else//Só para a fase de teste
                {
                    MessageBox.Show("Já existe i ficheiro!");

                }
            }
            catch
            {
                flag = false;
            }

            return flag;

        }

        //método para leitura do fciheiro
        private bool LerFicheiro()
        {
            bool flag = true;
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.txt";
            string[] dados = new string[2];

            try
            {
                if (File.Exists(path))
                {
                    //ler os dados linha a linha com o streamreader
                    using(StreamReader file = new StreamReader(path))
                    {
                        int counter = 0;
                        string ln;
                        while ((ln = file.ReadLine()) != null)
                        {
                            dados[counter++] = ln;
                            //counter ++ já não se torna necessário
                        }
                        file.Close();
                        //MessageBox.Show("Lidas " + counter + " linhas!"); - para teste
                    }
                }
                //buscar o valor do array dados para a aplicação
                //MessageBox.Show("IP: " + dados[0]);
                //MessageBox.Show("Porta: " + dados[1]);

                string[] octetos = dados[0].Split('.');

                int i = 0;
                for(i = 0; i < octetos.Length -1; i++)
                {
                    Geral.ipserver = Geral.ipserver + int.Parse(octetos[i]) + ".";
                }
                Geral.ipserver = Geral.ipserver + int.Parse(octetos[i]);

                //IPAddress result = null;
                //IpAdress.TryParse(dados[0], out result; // Não trata os em decimal , mas sim em octal
                //if (result != null)
                //{
                //      Geral.ipserver = result.ToString();
                //}

                Geral.portaserver = dados[1];

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + "\nErro na leitura do ficheiro de configuração!");
                flag = false; 
            }
            return flag;
        }

    }
}
