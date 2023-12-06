using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSalario
{
    public partial class WebFormSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblIRS.Text = "";
            LblVIRS.Text = string.Empty;
            LblCalculo.Text = string.Empty;
            TxtSalarioL.ReadOnly = true;
            TxtSegSocial.ReadOnly = true;

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            float salario = 0F, segSocial = 0F, liquido = 0F;
            if((TxtSalarioB.Text.Trim()).Length > 0)
            {
                try
                {
                    salario = float.Parse("0" + TxtSalarioB.Text);
                    segSocial = salario * 0.2F;
                    TxtSegSocial.Text = segSocial.ToString("0.00");

                    if (salario < 500)
                    {
                        LblIRS.Text = "0";
                        LblVIRS.Text = "0.00";
                        liquido = salario - segSocial;
                    }

                    else if (salario < 1000)
                    {
                        LblIRS.Text = "12";
                        LblVIRS.Text = (salario * 0.12F).ToString("0.00");
                        liquido = salario - segSocial - salario * 0.12F;
                    }

                    else if (salario < 1500)
                    {
                        LblIRS.Text = "15";
                        LblVIRS.Text = (salario * 0.15F).ToString("0.00");
                        liquido = salario - segSocial - salario * 0.15F;
                    }

                    else
                    {
                        LblIRS.Text = "18";
                        LblVIRS.Text = (salario * 0.18F).ToString("0.00");
                        liquido = salario - segSocial - salario * 0.18F;
                    }

                    LblCalculo.ForeColor = System.Drawing.Color.Green;
                    LblCalculo.Text = (salario.ToString("0.00") + " - " + segSocial.ToString("0.00") + " - " + LblVIRS.Text);
                    TxtSalarioL.Text = liquido.ToString("0.00");
                }

                catch
                {
                    Limpar();
                    LblCalculo.ForeColor= System.Drawing.Color.Red;
                    LblCalculo.Text = "Erro!";
                }
            }
            else
            {
                Limpar();
                LblCalculo.ForeColor = System.Drawing.Color.RoyalBlue;
                LblCalculo.Text = "Indique um valor!";
            }
        }
        void Limpar()
        {

            LblIRS.Text = "";
            LblVIRS.Text = string.Empty;
            LblCalculo.Text = string.Empty;
            TxtSalarioL.Text = "";
            TxtSegSocial.Text = string.Empty;
        }
    }
}