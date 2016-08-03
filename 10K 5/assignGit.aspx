<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignGit.aspx.cs" Inherits="_10K_5.assignGit" UnobtrusiveValidationMode=None Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Width="161px"  Text="Enter Github username:"/>
        <asp:TextBox ID="GitAcc" runat="server"></asp:TextBox>
    </div>
        <asp:Label runat="server" Width="161px"  Text="Choose Team:"/>
        <asp:DropDownList ID="TeamList" runat="server" Width="161px"  />
        <p>
        <asp:Button ID="GitAssign" runat="server" Text="Join Team" OnClick="GitAssign_Click" />
        </p>
        <asp:Label runat="server" Width="161px"  Text="Choose Project:"/>
        <asp:DropDownList ID="RepoList" runat="server" Width="161px"  />
        <p>
        <asp:Label runat="server" Width="161px"  Text="Project Description:"/>
        <asp:TextBox ID="Descriptiontxt" runat="server" Height="124px" Width="312px" Text="<%# description%>"/>
        </p>
        <p>
        <asp:Button ID="AddCollab" runat="server" Text="Join Project" OnClick="AddCollab_Click" />
        </p>
        <p>
            <asp:Label runat="server" Width="161px"  Text="10KNetwork Members:"/>
            <asp:ListBox ID="MemberList" runat="server" Width="161px" OnSelectedIndexChanged="Select"  AutoPostBack="true"/>

        </p>
        <asp:ListBox runat="server" ID="Listl" AutoPostBack="true">
        </asp:ListBox>
    </form>
</body>
</html>
