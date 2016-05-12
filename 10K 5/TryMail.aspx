<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryMail.aspx.cs" Inherits="_10K_5.TryMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:10KConnectionString %>" SelectCommand="SELECT * FROM [Applicants]"></asp:SqlDataSource>
    </form>
</body>
</html>
