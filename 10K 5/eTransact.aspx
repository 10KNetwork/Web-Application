<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eTransact.aspx.cs" Inherits="_10K_5.eTransact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .center{
            width:200px;
            margin:auto;
            font-family:'Segoe UI';           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="center">
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Cash" runat="server" Text="Pay Cash" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="eWallet" runat="server" Text="Pay with MPower" OnClick="eWallet_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
