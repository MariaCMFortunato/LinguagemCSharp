namespace GestaoFormacao_PF
{
    partial class FormApagarFormando
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbSitEmprego = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nUDIDFormando = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).BeginInit();
            this.grpBoxPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(302, 14);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cmbSitEmprego
            // 
            this.cmbSitEmprego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSitEmprego.FormattingEnabled = true;
            this.cmbSitEmprego.Items.AddRange(new object[] {
            "-",
            "Empregado",
            "Desempregado à procura do 1º emprego",
            "Desempregado à procura de novo emprego"});
            this.cmbSitEmprego.Location = new System.Drawing.Point(127, 159);
            this.cmbSitEmprego.Name = "cmbSitEmprego";
            this.cmbSitEmprego.Size = new System.Drawing.Size(249, 21);
            this.cmbSitEmprego.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Situação no emprego:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(126, 83);
            this.txtLocalidade.MaxLength = 100;
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(321, 20);
            this.txtLocalidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Localidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 46);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnApagar);
            this.groupBox3.Location = new System.Drawing.Point(5, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nUDIDFormando
            // 
            this.nUDIDFormando.Location = new System.Drawing.Point(124, 24);
            this.nUDIDFormando.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUDIDFormando.Name = "nUDIDFormando";
            this.nUDIDFormando.Size = new System.Drawing.Size(100, 20);
            this.nUDIDFormando.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Formando";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(126, 14);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(100, 20);
            this.txtNIF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIF:";
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.Location = new System.Drawing.Point(126, 121);
            this.mtxtDataNascimento.Mask = "00-00-0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(73, 20);
            this.mtxtDataNascimento.TabIndex = 7;
            // 
            // grpBoxPesquisa
            // 
            this.grpBoxPesquisa.Controls.Add(this.btnPesquisa);
            this.grpBoxPesquisa.Controls.Add(this.nUDIDFormando);
            this.grpBoxPesquisa.Controls.Add(this.label1);
            this.grpBoxPesquisa.Location = new System.Drawing.Point(7, 2);
            this.grpBoxPesquisa.Name = "grpBoxPesquisa";
            this.grpBoxPesquisa.Size = new System.Drawing.Size(463, 70);
            this.grpBoxPesquisa.TabIndex = 0;
            this.grpBoxPesquisa.TabStop = false;
            this.grpBoxPesquisa.Text = "Pesquisar Formando";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::GestaoFormacao_PF.Properties.Resources.Zoom;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Location = new System.Drawing.Point(321, 15);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(54, 36);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSitEmprego);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLocalidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNIF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxtDataNascimento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(5, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Nascimento:";
            // 
            // FormApagarFormando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 347);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBoxPesquisa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApagarFormando";
            this.Text = "Apagar Ficha Formando";
            this.Load += new System.EventHandler(this.FormApagarFormando_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDIDFormando)).EndInit();
            this.grpBoxPesquisa.ResumeLayout(false);
            this.grpBoxPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbSitEmprego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nUDIDFormando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.GroupBox grpBoxPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}