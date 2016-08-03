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
                <div class="panel-heading">First Bootstrap Project</div>
                <div class="panel-body">
                    <div class="col-lg-6">
                        <p>Bootstrap was created at Twitter in mid-2010 by @mdo and @fat.
                           Prior to being an open-sourced framework, Bootstrap was known as Twitter Blueprint. 
                           A few months into development, Twitter held its first Hack Week and the project exploded as developers of all skill levels jumped in without any external guidance. 
                            It served as the style guide for internal tools development at the company for over a year before its public release, and continues to do so today.</p>

                        <p>Originally released on Friday, August 19, 2011, we've since had over twenty releases, including two major rewrites with v2 and v3. With Bootstrap 2, we added responsive functionality to the entire framework as an optional stylesheet. 
                            Building on that with Bootstrap 3, we rewrote the library once more to make it responsive by default with a mobile first approach.</p>

                    </div>
                    <div class="col-lg-6">
                        <img src="gallery/Bootstrap.jpg" class="img-thumbnail"/>
                    </div>
                </div>
            </div>
        </div>

        <div class="container mypanel">
            <div class="panel panel-primary">
                <div class="panel-heading">This is CSS 3</div>
                <div class="panel-body">
                    <div class="col-lg-6">
                        <img src="gallery/css3.jpg" class="img-thumbnail"/>
                    </div>
                    <div class="col-lg-6">
                        <p>CSS is a stylesheet language that describes the presentation of an HTML (or XML) document.
                            CSS describes how elements must be rendered on screen, on paper, or in other media.</p>
                    </div>
                </div>
            </div>
        </div>

        <div class="container mypanel">
            <div class="panel panel-primary">
                <div class="panel-heading">Another Bootstrap Project</div>
                <div class="panel-body">
                    <div class="col-lg-6">
                        <p>Originally created by a designer and a developer at Twitter, Bootstrap has become one of the most popular front-end frameworks and open source projects in the world.</p>
                        <p>Bootstrap is maintained by the founding team and a small group of invaluable core contributors, with the massive support and involvement of our community.</p>
                    </div>
                    <div class="col-lg-6">
                        <img src="gallery/boots.png" class="img-thumbnail"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
