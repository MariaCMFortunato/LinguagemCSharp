using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class WebFormTriangulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculaR_Click(object sender, EventArgs e)
        {

            try
            {
                lblResultado3.Text = (double.Parse(txtBase.Text) * double.Parse(txtAltura2.Text)).ToString();
                if (double.Parse(txtBase.Text) == double.Parse(txtAltura2.Text))
                {
                    lblResultado3.Text = lblResultado3.Text + " --> É um quadrado!!!";
                }
            }
            catch
            {
                lblResultado3.Text = "Erro!";
            }
        }

        protected void lbtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormPrincipal.aspx");
        }
    }
}