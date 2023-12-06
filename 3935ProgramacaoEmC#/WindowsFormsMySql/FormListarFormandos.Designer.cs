namespace WindowsFormsMySql
{
    partial class FormListarFormandos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarFormandos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblRegistos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnPesquisa);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(47, 26);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 22);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = global::WindowsFormsMySql.Properties.Resources.pesquisa__1_;
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(627, 21);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(53, 29);
            this.BtnPesquisa.TabIndex = 3;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Controls.Add(this.rbOutro);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Controls.Add(this.rbFeminino);
            this.groupBox2.Location = new System.Drawing.Point(330, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(226, 20);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(59, 20);
            this.rbTodos.TabIndex = 17;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutro.Location = new System.Drawing.Point(171, 19);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(57, 20);
            this.rbOutro.TabIndex = 16;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(84, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(84, 20);
            this.rbMasculino.TabIndex = 15;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(5, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(78, 20);
            this.rbFeminino.TabIndex = 14;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(594, 348);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 25);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblRegistos
            // 
            this.lblRegistos.AutoSize = true;
            this.lblRegistos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistos.Location = new System.Drawing.Point(7, 352);
            this.lblRegistos.Name = "lblRegistos";
            this.lblRegistos.Size = new System.Drawing.Size(80, 16);
            this.lblRegistos.TabIndex = 3;
            this.lblRegistos.Text = "Nº Registos:";
            // 
            // FormListarFormandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 376);
            this.Controls.Add(this.lblRegistos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListarFormandos";
            this.Text = "Listar Formandos";
            this.Load += new System.EventHandler(this.FormListarFormandos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblRegistos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}