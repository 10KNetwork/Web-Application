<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="_10K_5.Gallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Projects</title>

    <style>
        .mypanel{
            padding-top:100px;
        }

        .jumbotron{
             background-color:#0c6423;
             color:white;
             text-align:center;
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
                <a class="navbar-brand page-scroll" href="Home.aspx">The 10K Network</a>
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
            
        <div class="container">
            <div class="jumbotron">
            <h1>Our Projects!</h1>
            </div>
        </div>

        <div class="container mypanel">
            <div class="panel panel-primary">
                <div class="panel-heading">Project 1</div>
                <div class="panel-body">Project 1 details</div>
            </div>
        </div>

        <div class="container mypanel">
            <div class="panel panel-primary">
                <div class="panel-heading">Project 2</div>
                <div class="panel-body">Project 2 details</div>
            </div>
        </div>

        <div class="container mypanel">
            <div class="panel panel-primary">
                <div class="panel-heading">Project 3</div>
                <div class="panel-body">Project 3 details</div>
            </div>
        </div>
    </form>
</body>
</html>
