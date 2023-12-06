using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class WebFormRetangulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculaR_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (double.Parse(txtAltura.Text) * double.Parse(txtComprimento.Text)).ToString();
                if (double.Parse(txtAltura.Text) == double.Parse(txtComprimento.Text))
                {
                    lblResultado.Text = lblResultado.Text + " --> É um quadrado!!!";
                }
            }
            catch 
            {
                lblResultado.Text = "Erro!";
            }
        }

        protected void lbtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormPrincipal.aspx");
        }
    }
}