namespace WindowsFormsMySql
{
    partial class FormAtualizarFormandos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarFormandos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mtxtContacto = new System.Windows.Forms.MaskedTextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPesquisa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudId);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = global::WindowsFormsMySql.Properties.Resources.pesquisa__1_;
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(289, 10);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(53, 29);
            this.BtnPesquisa.TabIndex = 2;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // nudId
            // 
            this.nudId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudId.Location = new System.Drawing.Point(139, 14);
            this.nudId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 22);
            this.nudId.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(90, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 29);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNasc.Location = new System.Drawing.Point(139, 219);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.Size = new System.Drawing.Size(85, 22);
            this.mtxtDataNasc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Nascimento:";
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutro.Location = new System.Drawing.Point(377, 172);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(57, 20);
            this.rbOutro.TabIndex = 11;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(248, 172);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(84, 20);
            this.rbMasculino.TabIndex = 10;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(139, 172);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(78, 20);
            this.rbFeminino.TabIndex = 9;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sexo:";
            // 
            // txtIban
            // 
            this.txtIban.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIban.Location = new System.Drawing.Point(139, 127);
            this.txtIban.MaxLength = 25;
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(522, 22);
            this.txtIban.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "IBAN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(5, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(302, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(103, 29);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // mtxtContacto
            // 
            this.mtxtContacto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtContacto.Location = new System.Drawing.Point(139, 91);
            this.mtxtContacto.Mask = "000000000";
            this.mtxtContacto.Name = "mtxtContacto";
            this.mtxtContacto.Size = new System.Drawing.Size(88, 22);
            this.mtxtContacto.TabIndex = 5;
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(139, 54);
            this.txtMorada.MaxLength = 100;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(522, 22);
            this.txtMorada.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(139, 17);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contacto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtDataNasc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rbOutro);
            this.groupBox3.Controls.Add(this.rbMasculino);
            this.groupBox3.Controls.Add(this.rbFeminino);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIban);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.mtxtContacto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMorada);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(5, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 256);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // FormAtualizarFormandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizarFormandos";
            this.Text = "Atualizar Formandos";
            this.Load += new System.EventHandler(this.FormAtualizarFormandos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox mtxtContacto;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnPesquisa;
    }
}