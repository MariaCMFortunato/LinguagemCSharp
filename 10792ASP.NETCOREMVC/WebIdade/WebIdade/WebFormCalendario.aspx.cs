using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebIdade
{
    public partial class WebFormCalendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            if (!IsPostBack) 
            {
                for (int i = 1; i < 31;i++) 
                { 
                    DropDownListDia.Items.Add(i.ToString());
                }

                for (int i = 1; i < 12; i++)
                {
                    DropDownListMes.Items.Add(i.ToString());
                }

                for (int i = DateTime.Today.Year; i >= 1900; i--)
                {
                    DropDownListAno.Items.Add(i.ToString());
                }

                DropDownListAno.Items.FindByText("2000").Selected = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime datanascimento, hoje;
            datanascimento = Calendar1.SelectedDate;
            hoje = DateTime.Today;
            int idade;

            if (Label2.Text == "")
            {
                Label1.Text = "Tem de indicar uma data!";
            }
            else
            {
                idade = hoje.Year - datanascimento.Year;


                if (datanascimento > hoje.AddYears(-idade))
                {
                    //Ainda não fez anos
                    Label3.Text = "Ainda falta(m)" + (datanascimento.AddYears(idade) - hoje).TotalDays.ToString() +
                        "dia(s) para o aniversário!";
                    idade--;
                }
                else
                {
                    //Já fez anos
                    Label3.Text = "Ainda falta(m)" + (datanascimento.AddYears(idade + 1) - hoje).TotalDays.ToString() +
                        "dia(s) para o aniversário!";
                }

                Label1.Text = idade.ToString() + "anos";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try 
            {
                DateTime dateTime = Convert.ToDateTime(TextBox1.Text);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                Label2.Text = Calendar1.SelectedDate.ToShortDateString();
                Label3.Text = "";
            }
            catch 
            {
                TextBox1.Text = "Data incorreta!";
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + TextBox1.Text + "');", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String data = DropDownListDia.SelectedValue + "/" + DropDownListMes.SelectedValue + "/" + DropDownListAno.SelectedValue;
            try 
            {
                DateTime dateTime = Convert.ToDateTime(data);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                Label2.Text = Calendar1.SelectedDate.ToShortDateString();
                TextBox1.Text = data;
                Label3.Text = "";
            }
            catch 
            {
                TextBox1.Text = "Data incorreta!";
            }
        }
    }
}