namespace WindowsFormsMySql
{
    partial class FormInserirFormandos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirFormandos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtContacto = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtDataNasc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbOutro);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtContacto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMorada);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNasc.Location = new System.Drawing.Point(139, 254);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.Size = new System.Drawing.Size(85, 22);
            this.mtxtDataNasc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Nascimento:";
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutro.Location = new System.Drawing.Point(377, 207);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(57, 20);
            this.rbOutro.TabIndex = 13;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(248, 207);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(84, 20);
            this.rbMasculino.TabIndex = 12;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(139, 207);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(78, 20);
            this.rbFeminino.TabIndex = 11;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo:";
            // 
            // txtIban
            // 
            this.txtIban.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIban.Location = new System.Drawing.Point(139, 162);
            this.txtIban.MaxLength = 25;
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(535, 22);
            this.txtIban.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "IBAN:";
            // 
            // mtxtContacto
            // 
            this.mtxtContacto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtContacto.Location = new System.Drawing.Point(139, 126);
            this.mtxtContacto.Mask = "000000000";
            this.mtxtContacto.Name = "mtxtContacto";
            this.mtxtContacto.Size = new System.Drawing.Size(88, 22);
            this.mtxtContacto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contacto:";
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(139, 89);
            this.txtMorada.MaxLength = 100;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(535, 22);
            this.txtMorada.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(139, 52);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(535, 22);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // nudId
            // 
            this.nudId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudId.Location = new System.Drawing.Point(139, 17);
            this.nudId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 22);
            this.nudId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(142, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(267, 22);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 29);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(75, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 29);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormInserirFormandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInserirFormandos";
            this.Text = "Inserir Formandos";
            this.Load += new System.EventHandler(this.FormInserirFormandos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}