<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="MyForm.Try2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RENEWAL</title>
    <style>
        body{
            background-image:url('asanoha-400px.png')
        }
    </style>
    <link href="first/first.css" rel="stylesheet" />
    <link href="second.css" rel="stylesheet" />
</head>
<body>
    <!-- multistep form -->
    <form id="msform" runat="server">
 
  <!-- progressbar -->
  <ul id="progressbar">
    <li class="active">Account Setup</li>
    <li>Make Payment</li>
    <li>Join the Network</li>
  </ul>
  <!-- fieldsets -->
  <fieldset>
    <h2 class="fs-title">Create your account</h2>
    <h3 class="fs-subtitle">Congratulations, you're joining us!</h3>
     <input type="text" name="fname" placeholder="First Name" />
    <input type="text" name="lname" placeholder="Last Name" />
    <input type="text" name="uname" placeholder="Username" />
    <input type="text" name="email" placeholder="Email" />
    <input type="password" name="pass" placeholder="Password" />
    <input type="password" name="cpass" placeholder="Confirm Password" />
    <input type="button" name="next" class="next action-button" value="Next" />
  </fieldset>
  <fieldset>
    <h2 class="fs-title">Make Payment</h2>
    <h3 class="fs-subtitle">A Mentor is ready to help!</h3>
    <input type="submit" name="eWallet" class="submit action-button" value="Subscribe" />
    <input type="button" name="previous" class="previous action-button" value="Previous" />
    <input type="button" name="next" class="next action-button" value="Next" />
  </fieldset>
  <fieldset>
    <h2 class="fs-title">Join the Network</h2>
    <h3 class="fs-subtitle">So glad you're joining us!</h3>
    <input type="text" name="git" placeholder="Github Account" />
    
    <input type="button" name="previous" class="previous action-button" value="Previous" />
    <input type="submit" name="submit" class="submit action-button" value="Submit" />
  </fieldset>
</form>

    <script type="text/javascript" src="second.js"></script>
    <script src="../js/jquery.easing.min.js"></script>
    <script src="../js/jquery.js"></script>
</body>
</html>
