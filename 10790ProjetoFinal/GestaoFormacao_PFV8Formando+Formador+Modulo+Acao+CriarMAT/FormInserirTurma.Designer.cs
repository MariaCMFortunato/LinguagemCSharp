namespace GestaoFormacao_PF
{
    partial class FormInserirTurma
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nuIDRegisto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDIDModulo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDAcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDIDFormando = new System.Windows.Forms.NumericUpDown();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.cmbFormando = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIDRegisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnGravar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Location = new System.Drawing.Point(3, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(382, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(86, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nuIDRegisto);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 51);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // nuIDRegisto
            // 
            this.nuIDRegisto.Location = new System.Drawing.Point(472, 19);
            this.nuIDRegisto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nuIDRegisto.Name = "nuIDRegisto";
            this.nuIDRegisto.Size = new System.Drawing.Size(100, 20);
            this.nuIDRegisto.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID Registo:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Ação:";
            // 
            // txtIDAcao
            // 
            this.txtIDAcao.Location = new System.Drawing.Point(86, 56);
            this.txtIDAcao.Name = "txtIDAcao";
            this.txtIDAcao.Size = new System.Drawing.Size(100, 20);
            this.txtIDAcao.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID Formando:";
            // 
            // nUDIDFormando
            // 
            this.nUDIDFormando.Location = new System.Drawing.Point(87, 92);
            this.nUDIDFormando.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUDIDFormando.Name = "nUDIDFormando";
            this.nUDIDFormando.Size = new System.Drawing.Size(100, 20);
            this.nUDIDFormando.TabIndex = 19;
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(192, 21);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(384, 21);
            this.cmbModulo.TabIndex = 20;
            this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.cmbModulo_SelectedIndexChanged);
            // 
            // cmbAcao
            // 
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(192, 57);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(384, 21);
            this.cmbAcao.TabIndex = 21;
            this.cmbAcao.SelectedIndexChanged += new System.EventHandler(this.cmbAcao_SelectedIndexChanged);
            // 
            // cmbFormando
            // 
            this.cmbFormando.FormattingEnabled = true;
            this.cmbFormando.Location = new System.Drawing.Point(192, 91);
            this.cmbFormando.Name = "cmbFormando";
            this.cmbFormando.Size = new System.Drawing.Size(384, 21);
            this.cmbFormando.TabIndex = 23;
            this.cmbFormando.SelectedIndexChanged += new System.EventHandler(this.cmbFormando_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFormando);
            this.groupBox1.Controls.Add(this.cmbAcao);
            this.groupBox1.Controls.Add(this.cmbModulo);
            this.groupBox1.Controls.Add(this.nUDIDFormando);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIDAcao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUDIDModulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // FormInserirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 259);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInserirTurma";
            this.Text = "Criar Turma";
            this.Load += new System.EventHandler(this.FormInserirTurma_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIDRegisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nuIDRegisto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDIDModulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDAcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDIDFormando;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.ComboBox cmbFormando;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}