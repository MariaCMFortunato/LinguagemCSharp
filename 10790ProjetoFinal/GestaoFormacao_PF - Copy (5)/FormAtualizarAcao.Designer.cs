namespace GestaoFormacao_PF
{
    partial class FormAtualizarAcao
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
            this.txtIDAcao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtReferencial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDAcao
            // 
            this.txtIDAcao.Location = new System.Drawing.Point(113, 21);
            this.txtIDAcao.Name = "txtIDAcao";
            this.txtIDAcao.Size = new System.Drawing.Size(100, 20);
            this.txtIDAcao.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(307, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnAtualizar);
            this.groupBox3.Location = new System.Drawing.Point(6, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "-",
            "Manhã",
            "Tarde",
            "Pós-Laboral"});
            this.cmbHorario.Location = new System.Drawing.Point(108, 142);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbHorario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Horário:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(108, 184);
            this.txtLocalidade.MaxLength = 100;
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(321, 20);
            this.txtLocalidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Localidade:";
            // 
            // mtxtDataFim
            // 
            this.mtxtDataFim.Location = new System.Drawing.Point(108, 99);
            this.mtxtDataFim.Mask = "00-00-0000";
            this.mtxtDataFim.Name = "mtxtDataFim";
            this.mtxtDataFim.Size = new System.Drawing.Size(73, 20);
            this.mtxtDataFim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Fim:";
            // 
            // mtxtDataInicio
            // 
            this.mtxtDataInicio.Location = new System.Drawing.Point(108, 57);
            this.mtxtDataInicio.Mask = "00-00-0000";
            this.mtxtDataInicio.Name = "mtxtDataInicio";
            this.mtxtDataInicio.Size = new System.Drawing.Size(73, 20);
            this.mtxtDataInicio.TabIndex = 3;
            // 
            // txtReferencial
            // 
            this.txtReferencial.Location = new System.Drawing.Point(108, 17);
            this.txtReferencial.MaxLength = 255;
            this.txtReferencial.Name = "txtReferencial";
            this.txtReferencial.Size = new System.Drawing.Size(338, 20);
            this.txtReferencial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Referencial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHorario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLocalidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mtxtDataFim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxtDataInicio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReferencial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data Início:";
            // 
            // grpBoxPesquisa
            // 
            this.grpBoxPesquisa.Controls.Add(this.txtIDAcao);
            this.grpBoxPesquisa.Controls.Add(this.btnPesquisa);
            this.grpBoxPesquisa.Controls.Add(this.label1);
            this.grpBoxPesquisa.Location = new System.Drawing.Point(7, 6);
            this.grpBoxPesquisa.Name = "grpBoxPesquisa";
            this.grpBoxPesquisa.Size = new System.Drawing.Size(465, 55);
            this.grpBoxPesquisa.TabIndex = 0;
            this.grpBoxPesquisa.TabStop = false;
            this.grpBoxPesquisa.Text = "Pesquisar Ação";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::GestaoFormacao_PF.Properties.Resources.Zoom;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Location = new System.Drawing.Point(392, 13);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(54, 36);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // FormAtualizarAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 351);
            this.Controls.Add(this.grpBoxPesquisa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizarAcao";
            this.Text = "Atualizar Acao Formacao";
            this.Load += new System.EventHandler(this.FormAtualizarAcao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxPesquisa.ResumeLayout(false);
            this.grpBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDAcao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtDataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtDataInicio;
        private System.Windows.Forms.TextBox txtReferencial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpBoxPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
    }
}