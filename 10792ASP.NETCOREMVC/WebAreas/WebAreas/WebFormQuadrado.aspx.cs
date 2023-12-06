using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class WebFormQuadrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculaQ_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado2.Text = (double.Parse(txtLado.Text) * double.Parse(txtLado.Text)).ToString();
            }
            catch
            {
                lblResultado2.Text = "Erro!";
            }
        }

        protected void lbtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormPrincipal.aspx");
        }
    }
}