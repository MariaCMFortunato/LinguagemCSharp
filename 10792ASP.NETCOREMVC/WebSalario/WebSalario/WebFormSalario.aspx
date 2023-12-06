<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSalario.aspx.cs" Inherits="WebSalario.WebFormSalario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cálculo de Salário</h2>
            <br />
            Salário Bruto:
            <asp:TextBox ID="TxtSalarioB" runat="server" Width="125px"></asp:TextBox>&nbsp;€&nbsp;&nbsp;
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br />
            <br />
            Segurança Social:
            <asp:TextBox ID="TxtSegSocial" runat="server" Width="125px"></asp:TextBox>&nbsp;€
            <br />
            <br />
            IRS&nbsp;
            <asp:Label ID="LblIRS" runat="server" Text="---"></asp:Label>&nbsp;%
            &nbsp;&nbsp;
            Valor IRS: <asp:Label ID="LblVIRS" runat="server" Text="---"></asp:Label>&nbsp;€
            <br />
            <br />
            <asp:Label ID="LblCalculo" runat="server" Text="---"></asp:Label>
            <br />
            <br />
            Salário Líquido:
            <asp:TextBox ID="TxtSalarioL" runat="server" Width="125px"></asp:TextBox>&nbsp;€
            <br />
            <br />
        </div>
    </form>
</body>
</html>
