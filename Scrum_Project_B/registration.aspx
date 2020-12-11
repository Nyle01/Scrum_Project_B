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
            <asp:Label ID="Label2" runat="server" ForeColor="#999999" Text="Firstname"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="txtbxName" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbxName" EnableClientScript="False" ErrorMessage="Please enter your Firstname"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label6" runat="server" ForeColor="#999999" Text="Lastname"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="txtbxName0" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtbxName" EnableClientScript="False" ErrorMessage="Please enter your Lastname"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label3" runat="server" ForeColor="#999999" Text="Email"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TxtbxEmail" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtbxEmail" EnableClientScript="False" ErrorMessage="Please enter a Email"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="ValidEmailValidator" runat="server" ControlToValidate="TxtbxEmail" EnableClientScript="False" ErrorMessage="Please enter a valid Email format" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label4" runat="server" ForeColor="#999999" Text="Password"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TxtbsPassw" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtbsPassw" EnableClientScript="False" ErrorMessage="Please enter a Password"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label5" runat="server" ForeColor="#999999" Text="Repeat your password"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TxtbsPasswRep" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtbsPasswRep" EnableClientScript="False" ErrorMessage="Please repeat your password"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label7" runat="server" ForeColor="#999999" Text="Organisation"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="TxtbsPasswRep0" runat="server" Width="380px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtbxName" EnableClientScript="False" ErrorMessage="Please enter your organisation"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 120px">
            &nbsp;</p>
        <p style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" Font-Size="Medium" ForeColor="#000099" Text="SIGN UP" Width="377px" OnClick="Button1_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
