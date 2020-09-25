<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WCFWebAppClient.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Enter Ecode:&nbsp; <asp:TextBox ID="TBEcode" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Ename:
            <asp:TextBox ID="TBEname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnFindbyEcode" runat="server" OnClick="bttnFindbyEcode_Click" Text="FIND BY ECODE" />
        </p>
        <p>
            Enter Salary:&nbsp; <asp:TextBox ID="TBSalary" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter DeptId: <asp:TextBox ID="TBDeptId" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="bttnAddEmp" runat="server" OnClick="bttnAddEmp_Click" Text="ADD EMP" />
&nbsp;&nbsp;
        <asp:Button ID="bttnDelete" runat="server" OnClick="bttnDelete_Click" Text="DELETE EMP" />
&nbsp;&nbsp;
        <asp:Button ID="bttnUpdate" runat="server" OnClick="bttnUpdate_Click" Text="UPDATE" />
        <br />
        <asp:Label ID="txtMsg" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
