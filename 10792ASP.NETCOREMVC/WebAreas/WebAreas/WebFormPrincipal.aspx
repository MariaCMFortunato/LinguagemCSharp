<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPrincipal.aspx.cs" Inherits="WebAreas.WebFormPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Áreas - Menu</h1>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Button ID="btnRetangulo" runat="server" Text="Retângulo" Width="125px" OnClick="btnRetangulo_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnCirculo" runat="server" Text="Circulo" Width="125px" OnClick="btnCirculo_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnQuadrado" runat="server" Text="Quadrado" Width="125px" OnClick="btnQuadrado_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnTriangulo" runat="server" Text="Triângulo" Width="125px" OnClick="btnTriangulo_Click" />
                    </td>
                </tr>
            </table>
            <br />

        </div>
    </form>
</body>
</html>
