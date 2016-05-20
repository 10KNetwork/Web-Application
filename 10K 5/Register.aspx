<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_10K_5.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>10K|REGISTER</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/scrolling-nav.css" rel="stylesheet">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

    <style>
        /*@font-face {
            font-family: 'orange juice';
            src: url('orange juice 2.0.ttf');
        }*/

        h1{
            font-family:'Segoe UI', sans-serif;
            text-align:center
        }

        .new{
            margin-top:150px;
            margin-right:auto;
            margin-left:auto

        }

        .center{
            width:200px;
            margin:auto;
            font-family:'Segoe UI'
        }

        input[type=text]{
            border:2px solid black;
            font-size:20px;
            margin-bottom:5px
        }

        input[type=password]{
            border:2px solid black;
            font-size:20px;
            margin-bottom:5px
        }

        input[type=email]{
            border:2px solid black;
            font-size:20px;
            margin-bottom:5px
        }

        /*input[]{
            border:2px solid black;
            font-size:20px;
            margin-bottom:5px
        }*/
        .dropdown{
            border:2px solid black;
            font-size:20px;
            margin-bottom:5px;
            width:100%
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <!-- Navigation -->
    <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header page-scroll">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand page-scroll" href="Main.aspx">The 10K Network</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse navbar-ex1-collapse">
                <ul class="nav navbar-nav">
                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                    <li class="hidden">
                        <a class="page-scroll" href="#page-top"></a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#about">About</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#services">Services</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#contact">Contact</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>
            <div class="new">
                <h1>NEW APPLICATION FORM</h1>
            </div>

        <br />
        <br />


        <div class="center">

            <table class="nav-justified">
                <tr>
                    <td>
                        <asp:TextBox ID="FName" runat="server" placeholder="First Name"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="LName" runat="server" placeholder="Last Name"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="Email" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="Area" runat="server"  CssClass="dropdown">
                            <asp:ListItem Selected="True">---Please Select---</asp:ListItem>
                            <asp:ListItem>Game Development</asp:ListItem>
                            <asp:ListItem>Web Development</asp:ListItem>
                            <asp:ListItem>Desktop Application</asp:ListItem>
                            <asp:ListItem>Mobile Application</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="Ref" runat="server" placeholder="Name of Referee"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="UName" runat="server" placeholder="Preferred Username"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="Pass" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="CPass" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="SUBMIT APPLICATION" OnClick="RegisterEventMethod" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" ForeColor="#009933" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:10KConnectionString %>" SelectCommand="SELECT * FROM [Applicants]"></asp:SqlDataSource>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
