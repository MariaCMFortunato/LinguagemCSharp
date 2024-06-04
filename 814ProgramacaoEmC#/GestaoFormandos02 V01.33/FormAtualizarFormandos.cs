using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GestaoFormandos02
{
    public partial class FormAtualizarFormandos : Form
    {
        DBConnect ligacao = new DBConnect();

        string contactoAux = "";

        public FormAtualizarFormandos()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormandos_Load(object sender, EventArgs e)
        {
            //txtNome.ReadOnly = true;
            //txtMorada.ReadOnly = true;
            //mtxtContacto.ReadOnly = true;
            //mtxtIBAN.ReadOnly = true;
            //rbtnFeminino.Enabled = false;
            //rbtnMasculino.Enabled = false;
            //rbtnOutro.Enabled = false;
            //mtxtDataNascimento.ReadOnly = true;
            //dateTimePicker1.Visible = false;

            DesativarControlos();
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
            btnAtualizar.Enabled = false;
            this.AcceptButton = this.btnPesquisa;

            nudID.Focus();
            nudID.Select(0, nudID.Value.ToString().Length);
        }

        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            mtxtIBAN.ReadOnly = true;
            rbtnFeminino.Enabled = false;
            rbtnMasculino.Enabled = false;
            rbtnOutro.Enabled = false;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;
            cmbNacionalidade.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtNome.ReadOnly = false;
            txtMorada.ReadOnly = false;
            mtxtContacto.ReadOnly = false;
            mtxtIBAN.ReadOnly = false;
            rbtnFeminino.Enabled = true;
            rbtnMasculino.Enabled = true;
            rbtnOutro.Enabled = true;
            mtxtDataNascimento.ReadOnly = false;
            //dateTimePicker1.Visible = false;
            cmbNacionalidade.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "", id_nacionalidade="";
            char genero = ' ';

            if (ligacao.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero,
                ref data_nascimento, ref id_nacionalidade))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                mtxtIBAN.Text = iban;
                if (genero == 'F')
                {
                    rbtnFeminino.Checked = true;
                }
                else if (genero == 'M')
                {
                    rbtnMasculino.Checked = true;
                }
                else if (genero == 'O')
                {
                    rbtnOutro.Checked = true;
                }
                mtxtDataNascimento.Text = data_nascimento;

                cmbNacionalidade.Text = ligacao.DevolverNacionalidade(id_nacionalidade);

                groupBox3.Enabled = false;
                btnAtualizar.Enabled = true;
                btnAtualizar.Focus();
                AtivarControlos();
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
                nudID.Value = 0;
                nudID.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);

                // mtxtContacto.Text = contacto auxiliar após tratamento
                if (ligacao.Update(nudID.Value.ToString(), txtNome.Text, txtMorada.Text, contactoAux,
                    mtxtIBAN.Text, Genero(), DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), id_nacionalidade))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            //Geral.TirarEspacos(ref txtNome);
            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }

            contactoAux = mtxtContacto.Text.Replace(" ", "");

            if (contactoAux.Length != 0 && contactoAux.Length != 9)
            {
                MessageBox.Show("Erro no campo Contacto!");
                mtxtContacto.Focus();
                return false;
            }

            if (mtxtIBAN.Text.Length < 25)
            {
                MessageBox.Show("Erro no campo IBAN!");
                mtxtIBAN.Focus();
                return false;
            }

            if (Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Género!");
                rbtnFeminino.Focus();
                return false;
            }

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            if (cmbNacionalidade.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo Nacionalidade!");
                cmbNacionalidade.Focus();
                return false;
            }

            return true;
        }

        private char Genero()
        {
            char genero = 'T';
            if (rbtnFeminino.Checked)
            {
                genero = 'F';
            }

            else if (rbtnMasculino.Checked)
            {
                genero = 'M';
            }

            else if (rbtnOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }

        private void mtxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            int dia, mes, ano;
            string textoData;
            DateTime data;
            if (mtxtDataNascimento.MaskCompleted)
            {
                textoData = mtxtDataNascimento.Text;
                dia = int.Parse(textoData.Substring(0, 2));
                mes = int.Parse(textoData.Substring(3, 2));
                ano = int.Parse(textoData.Substring(6));

                try
                {
                    data = DateTime.Parse(dia + "-" + mes + "-" + ano);
                    dateTimePicker1.Value = data;
                }
                catch
                {
                    MessageBox.Show("Data incorreta!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtDataNascimento.Focus();
                }
            }
        }

        public void LimparCampos()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            txtMorada.Text = "";
            mtxtContacto.Clear();
            mtxtIBAN.Text = string.Empty;
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnOutro.Checked = false;
            mtxtDataNascimento.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbNacionalidade.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnAtualizar.Enabled = false;

            LimparCampos();
            DesativarControlos();

            nudID.Focus();
            nudID.Select(0, nudID.Value.ToString().Length);
        }
    }
}
