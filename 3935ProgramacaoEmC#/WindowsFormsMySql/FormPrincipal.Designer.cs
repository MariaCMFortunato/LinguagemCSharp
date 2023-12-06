namespace WindowsFormsMySql
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formandosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formandosToolStripMenuItem
            // 
            this.formandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.apagarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listarToolStripMenuItem});
            this.formandosToolStripMenuItem.Name = "formandosToolStripMenuItem";
            this.formandosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.formandosToolStripMenuItem.Text = "&Formandos";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem.Text = "&Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarToolStripMenuItem.Text = "&Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem.Text = "A&pagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Lista&r";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Projeto 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
    }
}