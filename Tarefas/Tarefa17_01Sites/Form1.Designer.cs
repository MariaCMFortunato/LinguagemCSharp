namespace Tarefa17_01Sites
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            wbMicrosoft = new Microsoft.Web.WebView2.WinForms.WebView2();
            wbIEFP = new Microsoft.Web.WebView2.WinForms.WebView2();
            wbGoogle = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wbMicrosoft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wbIEFP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wbGoogle).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(linkLabel3);
            splitContainer1.Panel1.Controls.Add(linkLabel2);
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(wbMicrosoft);
            splitContainer1.Panel2.Controls.Add(wbIEFP);
            splitContainer1.Panel2.Controls.Add(wbGoogle);
            splitContainer1.Size = new Size(922, 450);
            splitContainer1.SplitterDistance = 234;
            splitContainer1.TabIndex = 0;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(12, 201);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(45, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Google";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(12, 123);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Microsoft Corporation";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 44);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(258, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "IEFP - Instituto Emprego Formação  Profissional";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // wbMicrosoft
            // 
            wbMicrosoft.AllowExternalDrop = true;
            wbMicrosoft.CreationProperties = null;
            wbMicrosoft.DefaultBackgroundColor = Color.White;
            wbMicrosoft.Location = new Point(3, 3);
            wbMicrosoft.MaximumSize = new Size(1080, 1080);
            wbMicrosoft.MinimumSize = new Size(200, 200);
            wbMicrosoft.Name = "wbMicrosoft";
            wbMicrosoft.Size = new Size(1080, 1080);
            wbMicrosoft.Source = new Uri("https://www.microsoft.com/pt-pt", UriKind.Absolute);
            wbMicrosoft.TabIndex = 1;
            wbMicrosoft.Visible = false;
            wbMicrosoft.ZoomFactor = 1D;
            // 
            // wbIEFP
            // 
            wbIEFP.AllowExternalDrop = true;
            wbIEFP.CreationProperties = null;
            wbIEFP.DefaultBackgroundColor = Color.White;
            wbIEFP.Location = new Point(3, 3);
            wbIEFP.MaximumSize = new Size(1080, 1080);
            wbIEFP.MinimumSize = new Size(200, 200);
            wbIEFP.Name = "wbIEFP";
            wbIEFP.Size = new Size(1080, 1080);
            wbIEFP.Source = new Uri("https://www.iefp.pt/", UriKind.Absolute);
            wbIEFP.TabIndex = 0;
            wbIEFP.Visible = false;
            wbIEFP.ZoomFactor = 1D;
            // 
            // wbGoogle
            // 
            wbGoogle.AllowExternalDrop = true;
            wbGoogle.CreationProperties = null;
            wbGoogle.DefaultBackgroundColor = Color.White;
            wbGoogle.Location = new Point(3, 3);
            wbGoogle.MaximumSize = new Size(1080, 1080);
            wbGoogle.MinimumSize = new Size(200, 200);
            wbGoogle.Name = "wbGoogle";
            wbGoogle.Size = new Size(1080, 1080);
            wbGoogle.Source = new Uri("https://www.google.pt/?hl=pt-PT", UriKind.Absolute);
            wbGoogle.TabIndex = 2;
            wbGoogle.Visible = false;
            wbGoogle.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wbMicrosoft).EndInit();
            ((System.ComponentModel.ISupportInitialize)wbIEFP).EndInit();
            ((System.ComponentModel.ISupportInitialize)wbGoogle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbIEFP;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbMicrosoft;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbGoogle;
    }
}