<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTriangulo.aspx.cs" Inherits="WebAreas.WebFormTriangulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cálculo da Área do Triângulo</h1>
            <br/>
            Base:
            <asp:TextBox ID="txtBase" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br />
            <br />
            Altura:
            <asp:TextBox ID="txtAltura2" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br />
            <br/>
            <asp:Button ID="btnCalculaT" runat="server" Text="Calcular" OnClick="btnCalculaR_Click" Width="100px" />
        &nbsp;<asp:Label ID="lblResultado3" runat="server"></asp:Label>
            <br/>
            <br />
            <asp:LinkButton ID="lbtnVoltar" runat="server" OnClick="lbtnVoltar_Click">voltar</asp:LinkButton>
            <br/>
            <br />
        </div>
    </form>
</body>
</html>
