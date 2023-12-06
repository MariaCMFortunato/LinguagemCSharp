<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRetangulo.aspx.cs" Inherits="WebAreas.WebFormRetangulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cálculo da Área do Retângulo</h1>
            <br/>
            Altura:
            <asp:TextBox ID="txtAltura" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br/>
            <br/>
            Comprimento:
            <asp:TextBox ID="txtComprimento" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalculaR_Click" Width="100px" />
            &nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br/>
            <br/>
            <asp:LinkButton ID="lbtnVoltar" runat="server" OnClick="lbtnVoltar_Click">voltar</asp:LinkButton>
            <br />
            <br>
        </div>
    </form>
</body>
</html>
