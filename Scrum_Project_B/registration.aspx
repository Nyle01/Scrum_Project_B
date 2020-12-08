<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Scrum_Project_B.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 240px">
            &nbsp;</p>
        <p style="margin-left: 200px">
            <asp:Label ID="Label1" runat="server" BackColor="White" Font-Size="XX-Large" ForeColor="Blue" Text="Create Account"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label2" runat="server" ForeColor="#999999" Text="Name"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TextBox1" runat="server" Width="380px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label3" runat="server" ForeColor="#999999" Text="Email"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TextBox2" runat="server" Width="380px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label4" runat="server" ForeColor="#999999" Text="Password"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TextBox3" runat="server" Width="380px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label5" runat="server" ForeColor="#999999" Text="Repeat your password"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TextBox4" runat="server" Width="380px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            &nbsp;</p>
        <p style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" Font-Size="Medium" ForeColor="#000099" Text="SIGN UP" Width="377px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
