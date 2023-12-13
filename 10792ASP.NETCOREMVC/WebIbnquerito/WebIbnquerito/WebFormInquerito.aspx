<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInquerito.aspx.cs" Inherits="WebIbnquerito.WebFormInquerito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inquérito</title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style5 {
            width: 100px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Inquérito de teste</h1>
            Nome:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="440px"></asp:TextBox>
            <br /> <br />
            Distrito
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="110px" Width="100px">
                <asp:ListItem>Braga</asp:ListItem>
                <asp:ListItem>Coimbra</asp:ListItem>
                <asp:ListItem>Faro</asp:ListItem>
                <asp:ListItem>Lisboa</asp:ListItem>
                <asp:ListItem>Porto</asp:ListItem>
            </asp:ListBox>
            <br /> <br />

            Pratos Favoritos
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:CheckBox ID="Pizza" runat="server" Text="Pizza" />
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="Bife" runat="server" Text="Bife" />
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="Massa" runat="server" Text="Massa" />
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="Kebab" runat="server" Text="Kebab" />
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="Sushi" runat="server" Text="Sushi" />
                    </td>
                </tr>
            </table>
            <br />
            Clube:
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:RadioButton ID="SCP" runat="server" Text="SCP" GroupName="Clube" />
                    </td>
                    <td class="auto-style5">
                        <asp:RadioButton ID="FCP" runat="server" Text="FCP" GroupName="Clube" />
                    </td>
                    <td class="auto-style5">
                        <asp:RadioButton ID="SLB" runat="server" Text="SLB" GroupName="Clube" />
                    </td>
                    <td class="auto-style5">
                        <asp:RadioButton ID="CFB" runat="server" Text="CFB" GroupName="Clube" />
                    </td>
                    <td class="auto-style5">
                        <asp:RadioButton ID="BFC" runat="server" Text="BFC" GroupName="Clube" />
               </tr>
                </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submeter" Width="100px" OnClick="Button1_Click" />
            <br /> <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


        </div>
    </form>
</body>
</html>
