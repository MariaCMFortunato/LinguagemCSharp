<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalendario.aspx.cs" Inherits="WebIdade.WebFormCalendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>
                Selecione a sua data de nascimento:&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </h4>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <br />
<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Carregar data" />
            <br />
            <br />
            Dia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Mês&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Ano
            <br />
            <asp:DropDownList ID="DropDownListDia" runat="server"></asp:DropDownList>&nbsp;
            <asp:DropDownList ID="DropDownListMes" runat="server"></asp:DropDownList>&nbsp;
            <asp:DropDownList ID="DropDownListAno" runat="server"></asp:DropDownList>
            &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Carregar data" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular Idade" />
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
