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
    public partial class FormAtualizarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_nacionalidade = string.Empty;
        public FormAtualizarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormAtualizarNacionalidade_Load(object sender, EventArgs e)
        {
            DesativarControlos();
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
            cmbNacionalidade.Focus();
        }

        private void DesativarControlos()
        {
            txtAlf2.ReadOnly = true;
            txtNacionalidade.ReadOnly = true;
            btnAtualizar.Enabled = false;
        }

        private void AtivarControlos()
        {
            txtAlf2.ReadOnly = false;
            txtNacionalidade.ReadOnly = false;
            btnAtualizar.Enabled = true;
        }

        public void LimparCampos()
        {
            cmbNacionalidade.SelectedIndex = -1;
            cmbNacionalidade.Enabled = true;
            txtAlf2.Text = string.Empty;
            txtNacionalidade.Text = string.Empty;

        }

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string alf2 = "", nacionalidade = "";
            if (cmbNacionalidade.SelectedIndex != -1)
            {
                //MessageBox.Show(cmbNacionalidade.Text);
                id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);
                //MessageBox.Show(id_nacionalidade);
                if (ligacao.PesquisaNacionalidade(id_nacionalidade, ref alf2, ref nacionalidade))
                {
                    AtivarControlos();
                    txtAlf2.Text = alf2;
                    txtNacionalidade.Text = nacionalidade;
                    
                    cmbNacionalidade.Enabled = false;
                    btnAtualizar.Enabled = true;
                    btnAtualizar.Focus();
                }
                else
                {
                    MessageBox.Show("Nacionalidade não encontrada!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnAtualizar.Enabled = false;
            DesativarControlos();
        }

        private bool VerificarCampos()
        {
            txtAlf2.Text = Geral.TirarEspacos(txtAlf2.Text);
            if (txtAlf2.Text.Length != 2)
            {
                MessageBox.Show("Erro no campo Alf2!");
                txtAlf2.Focus();
                return false;
            }
            txtNacionalidade.Text = Geral.TirarEspacos(txtNacionalidade.Text);
            if (txtNacionalidade.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nacionalidade!");
                txtNacionalidade.Focus();
                return false;
            }

            return true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);
            if (ligacao.UpdateNacionalidade(id_nacionalidade, txtAlf2.Text, txtNacionalidade.Text))
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
}