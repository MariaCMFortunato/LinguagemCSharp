<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormQuadrado.aspx.cs" Inherits="WebAreas.WebFormQuadrado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cálculo da Área do Quadrado</h1>
            <br/>
            Lado:
            <asp:TextBox ID="txtLado" runat="server" Height="20px" Width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalculaQ" runat="server" Text="Calcular" OnClick="btnCalculaQ_Click" Width="100px" />
            &nbsp;<asp:Label ID="lblResultado2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lbtnVoltar" runat="server" OnClick="lbtnVoltar_Click">voltar</asp:LinkButton>
            <br />
            <br>
        </div>
    </form>
</body>
</html>
