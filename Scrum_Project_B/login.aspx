<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Scrum_Project_B._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="design/login.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width,initial-scale=1,maximum-scale=1,user-scalable=no"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
<meta name="HandheldFriendly" content="true"/>
    <title></title>
</head>
<body>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
        media="screen" />
    <form id="form1" runat="server">
    <div>
        <h2 class="form-signin-heading">
            Login</h2>
        <label for="txtUsername">
            Username</label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username"
            required />
        <br />
        <label for="txtPassword">
            Password</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
            placeholder="Enter Password" required />
        <div class="checkbox">
            <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
        </div>
        <asp:Button ID="btnLogin" Text="Login" runat="server" Class="btn btn-primary" OnClick="btnLogin_Click" />
        <br />
        <br />
        <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
            <strong>Error!</strong>
            <asp:Label ID="lblMessage" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
