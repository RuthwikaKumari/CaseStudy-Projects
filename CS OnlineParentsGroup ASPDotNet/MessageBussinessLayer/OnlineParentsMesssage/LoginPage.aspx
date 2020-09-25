<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="OnlineParentsMesssage.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1"  style="width:40%;">
            <tr>
                <th colspan="2">Login User</th>
            </tr>
            <tr>
                <td>Enter Username:</td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    <asp:Label ID="txtmsg" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Enter Password:</td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" style="height: 35px" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/RegistrationPage.aspx">Register</asp:HyperLink>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
