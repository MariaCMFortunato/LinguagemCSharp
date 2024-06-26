﻿using System;
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
    public partial class FormApagarFormandos : Form
    {
        DBConnect conn = new DBConnect();
        public FormApagarFormandos()
        {
            InitializeComponent();
        }

        private void FormApagarFormandos_Load(object sender, EventArgs e)
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
            txtNacionalidade.ReadOnly = true;

            btnEliminar.Enabled = false;
            this.AcceptButton = this.btnPesquisa;


            nudID.Focus();
            nudID.Select(0, nudID.Value.ToString().Length);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "", id_nacionalidade="";
            char genero = ' ';

            if(conn.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero,
                ref data_nascimento, ref id_nacionalidade))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                mtxtIBAN.Text = iban;
                if(genero == 'F')
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

                txtNacionalidade.Text = conn.DevolverNacionalidade(id_nacionalidade);
                groupBox3.Enabled = false;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
                nudID.Value = 0;
                nudID.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnEliminar.Enabled=false;
            nudID.Focus();
            LimparCampos();
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
            txtNacionalidade.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja apagar o registo com o ID " + nudID.Value.ToString() + "?","Eliminar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(conn.Delete(nudID.Value.ToString())) 
                {
                    MessageBox.Show("Registo apagado!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar o resgisto!");
                }
            }
        }
    }
}
