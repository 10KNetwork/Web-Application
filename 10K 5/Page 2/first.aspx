<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="_10K_5.Page_2.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="first.css" rel="stylesheet" />
</head>
<body>
    <form id="msform" runat="server">
     <!-- fieldsets -->
  <div class="container">
      <fieldset>
    <h2 class="fs-title">Create your account</h2>
    <h3 class="fs-subtitle">Congratulations, you're joining us!</h3>
     <input type="text" name="fname" placeholder="First Name" id="FName" required/>
    <input type="text" name="lname" placeholder="Last Name" id="LName" required/>
    <input type="text" name="uname" placeholder="Username" id="UName" required/>
    <input type="text" name="email" placeholder="Email" id="Email" required/>
    <input type="password" name="pass" placeholder="Password" id="Pass" required/>
    <input type="password" name="cpass" placeholder="Confirm Password" id="CPass" required/>
    <input type="button" runat="server" name="next" class="next action-button" value="Register" id="submit" OnClick="EnterUser"/>
  </fieldset>
  </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:10KConnectionString %>" SelectCommand="SELECT * FROM [Renewal]"></asp:SqlDataSource>
    </form>
</body>
</html>
