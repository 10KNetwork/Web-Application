<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10.aspx.cs" Inherits="_10K_5._10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/10.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="form">
    
        <ul class="tab-group">
            <li class="tab active">
                <a href="#signup">Sign Up</a>
            </li>

            <li class="tab">
                <a href="#login">Log In</a>
            </li>
        </ul>

        <div class="tab-content">
            <div id="signup">
                <h1>Sign Up Here</h1>

                <form action="/" method="post">
                    <div class="top-row">
                        <div class="field-wrap">
                            <label>
                                First Name<span class="req">*</span>
                            </label>

                            <input type="text" required autocomplete="off"/>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    </form>
    <script src="js/10.js"></script>
</body>
</html>
