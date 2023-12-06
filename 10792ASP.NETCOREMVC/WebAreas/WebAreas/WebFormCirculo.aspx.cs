using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class WebFormCirculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculaC_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado4.Text = (double.Parse(txtRaio.Text) * double.Parse(txtRaio.Text)*Math.PI).ToString("0.00");
                
            }
            catch
            {
                lblResultado4.Text = "Erro!";
            }
        }

        protected void lbtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormPrincipal.aspx");
        }
    }
}