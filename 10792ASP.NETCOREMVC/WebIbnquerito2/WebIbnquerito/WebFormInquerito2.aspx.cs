using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebIbnquerito
{
    public partial class WebFormInquerito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            TextBox1.MaxLength = 60;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string display = "", comida = "", clube = "";
            if (Pizza.Checked) 
            { 
                comida = comida + Pizza.Text;
            }

            if (Bife.Checked) 
            { 
                if(comida.Length > 0) 
                {
                    comida = comida + ", ";
                }
                comida = comida + Bife.Text;
            }

            if (Massa.Checked)
            {
                if (comida.Length > 0)
                {
                    comida = comida + ", ";
                }
                comida = comida + Massa.Text;
            }

            if (Kebab.Checked)
            {
                if (comida.Length > 0)
                {
                    comida = comida + ", ";
                }
                comida = comida + Kebab.Text;
            }

            if (Sushi.Checked)
            {
                if (comida.Length > 0)
                {
                    comida = comida + " e ";
                } 
                comida = comida + Sushi.Text;
            }

            if(SCP.Checked)
            {
                clube = "Sporting Clube de Portugal";
            }

            else if (FCP.Checked)
            {
                clube = FCP.Text;
            }

            else if(SLB.Checked)
            {
                clube = SLB.Text;
            }

            else if (CFB.Checked)
            {
                clube = "Clube de Futebol OS Belenenses";
            }
            else if (BFC.Checked)
            {
                clube = "Boavista Futebol Clube";
            }
            display = TextBox1.Text + " vive em " + ListBox1.Text +
                ", gosta de comer " + comida + " e o seu clube do coração é o " + clube;
            Label1.Text = display;

            ClientScript.RegisterStartupScript(this.GetType(), "Mensagem", 
                "alert(´" + display + "´);", true);
            
            DBConnect ligacao = new DBConnect();

            if(ligacao.Insert(TextBox1.Text, ListBox1.Text, comida, clube))
            {
                Label1.Text = "Inseriu com Sucesso!";
            }
            else
            {
                Label1.Text = "Erro na inserção!";
            }

        }

    }
}