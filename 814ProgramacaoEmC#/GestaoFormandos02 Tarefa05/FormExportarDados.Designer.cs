namespace GestaoFormandos02
{
    partial class FormExportarDados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExportDados = new System.Windows.Forms.Button();
            this.chkLstColunas = new System.Windows.Forms.CheckedListBox();
            this.cmbTabelas = new System.Windows.Forms.ComboBox();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnExportFich = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnExportDados);
            this.groupBox1.Controls.Add(this.chkLstColunas);
            this.groupBox1.Controls.Add(this.cmbTabelas);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(263, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 28);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExportDados
            // 
            this.btnExportDados.Location = new System.Drawing.Point(402, 161);
            this.btnExportDados.Name = "btnExportDados";
            this.btnExportDados.Size = new System.Drawing.Size(98, 28);
            this.btnExportDados.TabIndex = 2;
            this.btnExportDados.Text = "Exportar Dados";
            this.btnExportDados.UseVisualStyleBackColor = true;
            this.btnExportDados.Click += new System.EventHandler(this.btnExportDados_Click);
            // 
            // chkLstColunas
            // 
            this.chkLstColunas.CheckOnClick = true;
            this.chkLstColunas.FormattingEnabled = true;
            this.chkLstColunas.Location = new System.Drawing.Point(263, 31);
            this.chkLstColunas.Name = "chkLstColunas";
            this.chkLstColunas.Size = new System.Drawing.Size(237, 124);
            this.chkLstColunas.TabIndex = 1;
            this.chkLstColunas.SelectedIndexChanged += new System.EventHandler(this.chkLstColunas_SelectedIndexChanged);
            // 
            // cmbTabelas
            // 
            this.cmbTabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabelas.FormattingEnabled = true;
            this.cmbTabelas.Location = new System.Drawing.Point(18, 29);
            this.cmbTabelas.Name = "cmbTabelas";
            this.cmbTabelas.Size = new System.Drawing.Size(209, 21);
            this.cmbTabelas.TabIndex = 0;
            this.cmbTabelas.SelectedIndexChanged += new System.EventHandler(this.cmbTabelas_SelectedIndexChanged);
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(8, 224);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDados.Size = new System.Drawing.Size(515, 216);
            this.txtDados.TabIndex = 1;
            this.txtDados.WordWrap = false;
            // 
            // btnExportFich
            // 
            this.btnExportFich.Location = new System.Drawing.Point(394, 446);
            this.btnExportFich.Name = "btnExportFich";
            this.btnExportFich.Size = new System.Drawing.Size(98, 28);
            this.btnExportFich.TabIndex = 3;
            this.btnExportFich.Text = "Exportar Ficheiro";
            this.btnExportFich.UseVisualStyleBackColor = true;
            this.btnExportFich.Click += new System.EventHandler(this.btnExportFich_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFiltro);
            this.groupBox2.Controls.Add(this.cmbOperadores);
            this.groupBox2.Controls.Add(this.cmbCampos);
            this.groupBox2.Location = new System.Drawing.Point(16, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // cmbCampos
            // 
            this.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.Location = new System.Drawing.Point(7, 29);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(149, 21);
            this.cmbCampos.TabIndex = 0;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Items.AddRange(new object[] {
            "",
            ">=",
            ">",
            "<=",
            "<",
            "=",
            "!=",
            "like"});
            this.cmbOperadores.Location = new System.Drawing.Point(162, 29);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(59, 21);
            this.cmbOperadores.TabIndex = 1;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(7, 73);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(214, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // FormExportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 484);
            this.Controls.Add(this.btnExportFich);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportarDados";
            this.Text = "Exportação Dados";
            this.Load += new System.EventHandler(this.FormExportarDados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTabelas;
        private System.Windows.Forms.CheckedListBox chkLstColunas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportDados;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnExportFich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}