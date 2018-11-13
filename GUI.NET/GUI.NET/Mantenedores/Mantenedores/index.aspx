<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Mantenedores.index" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js" type="text/javascript"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Home | OpenReality+</title>
    <%-- ------ CSS ------ --%>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/animate.min.css" rel="stylesheet" type="text/css" />
    <link href="css/prettyPhoto.css" rel="stylesheet" type="text/css" />
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <link href="css/responsive.css" rel="stylesheet" type="text/css" />
  
    <link href="css/stilo.css" rel="stylesheet" />
   
    <link rel="shortcut icon" href="imagenes/open-reality-plus-sin-fondo.png" />
</head>
<body>
    <form id="form1" runat="server">
        <header id="header">
   


      <nav class="navbar navbar-inverse nav_fondo" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.aspx"><img src="imagenes/open-reality-plus-sin-fondo.png" height="80" width="100" /></a>
                </div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class=""><a href="index.aspx">Home</a></li>
                                               
                       <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">¿Quienes Somos? <i class="fa fa-angle-down"></i></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Mision</a></li>
                                <li><a href="contacto.aspx">Contacto</a></li>
                                
                            </ul>
                        </li>
                        
                        <li><a href="contacto.aspx">Contacto</a></li>  
                        <li>
                            <asp:Button CssClass="boton_sesion"  ID="btnIniciarSesion" runat="server" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click" />

                        </li>
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
 
    </header>
        <section id="main-slider" class="no-margin">
        <div class="carousel slide">
            <ol class="carousel-indicators">
                <li data-target="#main-slider" data-slide-to="0" class="active"></li>
                <li data-target="#main-slider" data-slide-to="1"></li>
                <li data-target="#main-slider" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">

                <div class="item active" style="background-image: url(imagenes/blue.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">Con Open Reality + buscamos ayudar a personas con discapacidad.</h1>
                                    <h2 class="animation animated-item-2"></h2>
                                    <a class="btn-slide animation animated-item-3" href="iniciarSesion.aspx">inicia sesion.</a>
                                </div>
                            </div>

                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                   <img src="imagenes/open-reality-plus-sin-fondo.png" class="img-responsive" />
                                    
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!--/.item-->

                <div class="item" style="background-image: url(imagenes/2.png)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">Software patrocinado por Duoc UC.</h1>
                                    <h2 class="animation animated-item-2"></h2>
                                    <a class="btn-slide animation animated-item-3" href="iniciarSesion.aspx">Iniciar Sesion.</a>
                                </div>
                            </div>

                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <img src="imagenes/logo.png" class="img-responsive"  height="500" width=""/>
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!--/.item-->

                <div class="item" style="background-image: url(imagenes/3.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">Disponible para dispositivos Android.</h1>
                                    <h2 class="animation animated-item-2">(desde android 4.0 en adelante...)</h2>
                                    <a class="btn-slide animation animated-item-3" href="iniciarSesion.aspx">Inicia Sesion</a>
                                </div>
                            </div>
                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <img src="imagenes/android.png" class="img-responsive">
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
            </div><!--/.carousel-inner-->
        </div><!--/.carousel-->
        <a class="prev hidden-xs" href="#main-slider" data-slide="prev">
            <i class="fa fa-chevron-left"></i>
        </a>
        <a class="next hidden-xs" href="#main-slider" data-slide="next">
            <i class="fa fa-chevron-right"></i>
        </a>
    </section>
        <!--/#main-slider-->
        <section id="feature">
        <div class="container">
           <div class="center wow fadeInDown">
                <h2>Caracteristicas</h2>
                <%--<p class="lead">Easy to use, Responsive features, Mobile-first approach <br> Browser compatibility Bootstrap is compatible with all modern browsers</p>--%>
            </div>

            <div class="row">
                <div class="features">
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-th-list"></i>
                            <h2>Intuitivo</h2>
                            <h3>Manejo facil de usar para los usuarios</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-th"></i>
                            <h2>Android</h2>
                            <h3>Al funcionar en la plataforma android, funciona en muchos dispositivos.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-cloud-download"></i>
                            <h2>Facil descarga</h2>
                            <h3>Es super simple la forma de descargar la aplicacion.</h3>
                        </div>
                    </div><!--/.col-md-4-->
                
                    <%--<div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-comment"></i>
                            <h2>Modal & Tooltip</h2>
                            <h3>Modal is a dialog box/popup, Tooltip is small pop-up box</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-cogs"></i>
                            <h2>Facil configuracion</h2>
                            <h3>Solo inicias sesion en tu celular y listo.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-heart"></i>
                            <h2>Disponibilidad</h2>
                            <h3>Nuestra aplicacion esta disponible para todos los usuarios.</h3>
                        </div>
                    </div><!--/.col-md-4-->--%>
                </div><!--/.services-->
            </div><!--/.row-->    
        </div><!--/.container-->
    </section>
    <!--/#feature-->

        <section id="bottom">
        <div class="container wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Compañia</h3>
                        <ul>
                            <li><a href="#">¿Quienes somos?</a></li>
                            
                            <li><a href="#">Copyright</a></li>
                            <li><a href="#">Terminos de uso</a></li>
                            
                            <li><a href="contacto.aspx">Contacto</a></li>
                        </ul>
                    </div>    
                </div><!--/.col-md-3-->

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Soporte</h3>
                        <ul>
                            <li><a href="#">Faq</a></li>
                           
                            <li><a href="#">Documentacion</a></li>
                           
                            
                        </ul>
                    </div>    
                </div><!--/.col-md-3-->
                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Duoc UC</h3>
                        <ul>
                            <li><a href="http://www.duoc.cl/adm/">Home</a></li>
                            
                            <li><a href="http://www.duoc.cl/info/marco-normativo/normas-generales/Proyecto-Educativo-del-Instituto-Profesional-Duoc-UC.pdf">Proyecto</a></li>
                            <li><a href="https://www.facebook.com/DuocUC.SanJoaquin/">Duoc San joaquin</a></li>
                            
                            
                        </ul>
                    </div>    
                </div><!--/.col-md-3-->

                

                
            </div>
        </div>
    </section>
        <!--/#bottom-->
        <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2018 <a target="_blank" href="http://aspxtemplates.com/" title="">Open Reality +</a>. All Rights Reserved.
                </div>
                <div class="col-sm-6">
                    <ul class="pull-right">
                        <li><a href="#">Inicio</a></li>
                        <li><a href="#">¿Quienes somos?</a></li>
                        <li><a href="#">Faq</a></li>
                        <li><a href="contacto.aspx">Contactenos</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <a href="#" class="back-to-top"><i class="fa fa-2x fa-angle-up"></i></a>
    </footer>
        <!--/#footer-->
        <!-- Back To Top -->
        <script type="text/javascript">
            jQuery(document).ready(function () {
                var offset = 300;
                var duration = 500;
                jQuery(window).scroll(function () {
                    if (jQuery(this).scrollTop() > offset) {
                        jQuery('.back-to-top').fadeIn(duration);
                    } else {
                        jQuery('.back-to-top').fadeOut(duration);
                    }
                });

                jQuery('.back-to-top').click(function (event) {
                    event.preventDefault();
                    jQuery('html, body').animate({ scrollTop: 0 }, duration);
                    return false;
                })
            });
        </script>
        <!-- /top-link-block -->
        <!-- Jscript -->
        <script src="js/jquery.js" type="text/javascript"></script>
        <script src="js/bootstrap.min.js" type="text/javascript"></script>
        <script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
        <script src="js/jquery.isotope.min.js" type="text/javascript"></script>
        <script src="js/main.js" type="text/javascript"></script>
        <script src="js/wow.min.js" type="text/javascript"></script>
    </form>
</body>
</html>

