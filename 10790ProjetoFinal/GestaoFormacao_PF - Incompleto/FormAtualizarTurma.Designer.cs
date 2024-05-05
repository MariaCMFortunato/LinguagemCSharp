namespace GestaoFormacao_PF
{
    partial class FormAtualizarTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarTurma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.nuIDRegisto = new System.Windows.Forms.NumericUpDown();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.txtIDAcao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDIDModulo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFormando = new System.Windows.Forms.ComboBox();
            this.nUDIDFormando = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIDRegisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAcao);
            this.groupBox1.Controls.Add(this.nuIDRegisto);
            this.groupBox1.Controls.Add(this.cmbModulo);
            this.groupBox1.Controls.Add(this.txtIDAcao);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUDIDModulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cmbAcao
            // 
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(192, 57);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(384, 21);
            this.cmbAcao.TabIndex = 21;
            // 
            // nuIDRegisto
            // 
            this.nuIDRegisto.Location = new System.Drawing.Point(87, 92);
            this.nuIDRegisto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nuIDRegisto.Name = "nuIDRegisto";
            this.nuIDRegisto.Size = new System.Drawing.Size(100, 20);
            this.nuIDRegisto.TabIndex = 3;
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(192, 21);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(384, 21);
            this.cmbModulo.TabIndex = 20;
            // 
            // txtIDAcao
            // 
            this.txtIDAcao.Location = new System.Drawing.Point(86, 56);
            this.txtIDAcao.Name = "txtIDAcao";
            this.txtIDAcao.Size = new System.Drawing.Size(100, 20);
            this.txtIDAcao.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID Registo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Ação:";
            // 
            // nUDIDModulo
            // 
            this.nUDIDModulo.Location = new System.Drawing.Point(86, 21);
            this.nUDIDModulo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUDIDModulo.Name = "nUDIDModulo";
            this.nUDIDModulo.Size = new System.Drawing.Size(100, 20);
            this.nUDIDModulo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Módulo:";
            // 
            // cmbFormando
            // 
            this.cmbFormando.FormattingEnabled = true;
            this.cmbFormando.Location = new System.Drawing.Point(192, 16);
            this.cmbFormando.Name = "cmbFormando";
            this.cmbFormando.Size = new System.Drawing.Size(296, 21);
            this.cmbFormando.TabIndex = 23;
            this.cmbFormando.SelectedIndexChanged += new System.EventHandler(this.cmbFormando_SelectedIndexChanged);
            // 
            // nUDIDFormando
            // 
            this.nUDIDFormando.Location = new System.Drawing.Point(87, 17);
            this.nUDIDFormando.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUDIDFormando.Name = "nUDIDFormando";
            this.nUDIDFormando.Size = new System.Drawing.Size(100, 20);
            this.nUDIDFormando.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID Formando:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(413, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnAtualizar);
            this.groupBox3.Location = new System.Drawing.Point(6, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 62);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // grpBoxPesquisa
            // 
            this.grpBoxPesquisa.Controls.Add(this.cmbFormando);
            this.grpBoxPesquisa.Controls.Add(this.btnPesquisa);
            this.grpBoxPesquisa.Controls.Add(this.label4);
            this.grpBoxPesquisa.Controls.Add(this.nUDIDFormando);
            this.grpBoxPesquisa.Location = new System.Drawing.Point(6, 5);
            this.grpBoxPesquisa.Name = "grpBoxPesquisa";
            this.grpBoxPesquisa.Size = new System.Drawing.Size(582, 51);
            this.grpBoxPesquisa.TabIndex = 8;
            this.grpBoxPesquisa.TabStop = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Location = new System.Drawing.Point(514, 9);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(48, 36);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // FormAtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxPesquisa);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizarTurma";
            this.Text = "Atualizar Turma";
            this.Load += new System.EventHandler(this.FormAtualizarTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIDRegisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grpBoxPesquisa.ResumeLayout(false);
            this.grpBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormando;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.NumericUpDown nUDIDFormando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDAcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDIDModulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nuIDRegisto;
        private System.Windows.Forms.GroupBox grpBoxPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
    }
}