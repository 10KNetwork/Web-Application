<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign.aspx.cs" Inherits="_10K_5.Sign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>10K Network|Sign In</title>
    <link href="css/third.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        body{
            background-image:url('images/asanoha-400px.png')
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="table" id="mine">
        <tr>
            <td><h1>SIGN IN</h1>
        <h2>Good to have you back!</h2></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="USERNAME"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="PASSWORD"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SIGN IN" />
            </td>
        </tr>
    </table>
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
