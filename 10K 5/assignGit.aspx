<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignGit.aspx.cs" Inherits="_10K_5.assignGit" UnobtrusiveValidationMode=None Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="GitAcc" runat="server"></asp:TextBox>
        <asp:Button ID="GitAssign" runat="server" Text="Assign" OnClick="GitAssign_Click" />
        
    
    </div>
    </form>
</body>
</html>
