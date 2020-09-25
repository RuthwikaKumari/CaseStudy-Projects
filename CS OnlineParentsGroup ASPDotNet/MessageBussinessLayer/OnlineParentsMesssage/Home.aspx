<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineParentsMesssage.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body >
    <form id="form1" runat="server">
        <div >
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/LoginPage.aspx" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue">Post Your Message</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/BrowseMessages.aspx" Font-Bold="True" Font-Size="X-Large">Browse Messages</asp:HyperLink>
        </div>
    </form>
    </body>
</html>
