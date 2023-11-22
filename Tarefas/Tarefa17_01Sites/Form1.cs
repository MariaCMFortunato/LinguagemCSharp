namespace Tarefa17_01Sites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wbIEFP.Visible = true;
            wbMicrosoft.Visible = false;
            wbGoogle.Visible = false;
            //WebBrowser.Navigate("http://www.iefp.pt"); deprecated
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wbIEFP.Visible = false;
            wbMicrosoft.Visible = true;
            wbGoogle.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wbIEFP.Visible = false;
            wbMicrosoft.Visible = false;
            wbGoogle.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wbIEFP.Visible = false;
            wbMicrosoft.Visible = false;
            wbGoogle.Visible = false;
        }
    }
}