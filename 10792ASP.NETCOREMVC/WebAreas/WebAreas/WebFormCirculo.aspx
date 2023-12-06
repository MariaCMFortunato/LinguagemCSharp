<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCirculo.aspx.cs" Inherits="WebAreas.WebFormCirculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cálculo da Área do Círculo</h1>
            <br/>
            Raio:
            <asp:TextBox ID="txtRaio" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button ID="btnCalculaC" runat="server" Text="Calcular" OnClick="btnCalculaC_Click" Width="100px" /> 
            &nbsp;<asp:Label ID="lblResultado4" runat="server"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lbtnVoltar" runat="server" OnClick="lbtnVoltar_Click">voltar</asp:LinkButton>
            <br>
            <br />
        </div>
    </form>
</body>
</html>
