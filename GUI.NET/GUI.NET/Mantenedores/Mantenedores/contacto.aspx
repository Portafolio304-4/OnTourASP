<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="Mantenedores.contacto" %>

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
   
    <link rel="shortcut icon" href="imagenes/onTour.png" />
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
                    <a class="navbar-brand" href="index.aspx"><img src="imagenes/onTour.png" height="100" width="100" /></a>
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
                            <asp:Button CssClass="boton_sesion"  ID="btnIniciarSesion" runat="server" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click"/>

                        </li>
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
 
    </header>
        
     

        <section id="contact-info">
     <br /> <br />  
        <div class="center">                
            <h2>¿Donde Estamos?</h2>
            <%--<p class="lead">Get In Touch. More Bootstrap Templates will Update soon only for dot.net users...</p>--%>
     
        </div>
        <div class="gmap-area">
            <div class="container">
                <div class="row">
                    <div class="col-sm-5 text-center">
                        <div class="gmap">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3327.056269616732!2d-70.6186557851786!3d-33.49991310743781!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x9662d00be4a5fa81%3A0xcd8eaf5b1d547f64!2sDuoc+UC%3A+Sede+San+Joaqu%C3%ADn!5e0!3m2!1ses!2scl!4v1511541447165" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
                        </div>
                    </div>

                    <div class="col-sm-7 map-content">
                        <ul class="row">
                            <li class="col-sm-6">
                                <address>
                                    <h5>Citt San Joaquin</h5>
                                    <p><span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Av. Vicuña Mackenna 4917,</span> <br>
                                        <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Santiago, San Joaquín, Región Metropolitana.</span></p>
                                    <p>&nbsp;</p>
                                </address>

                                
                            </li>


                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--/gmap_area -->
    <section id="contact-page">
        <div class="container">
        <br />
        <br />
            <div class="center">        
                <h2>Dejanos tu mensaje</h2>
                <p class="lead">Deja tu consulta o sugerencia para ser respondida a la brevedad.</p>
            </div> 
            <div class="row contact-wrap"> 
                <div class="status alert alert-success" style="display: none"></div>
                <form id="main-contact-form" class="contact-form" name="contact-form" method="post" action="sendemail.php">
                    <div class="col-sm-5 col-sm-offset-1">
                        <div class="form-group">
                            <label>Nombre *</label>
                               <asp:TextBox ID="txtName" CssClass="form-control" runat="server" ></asp:TextBox>
                             </div>
                        <div class="form-group">
                            <label>Email *</label>
                            <asp:TextBox ID="txtemail" CssClass="form-control" runat="server" ></asp:TextBox>
                          
                        </div>
                        <div class="form-group">
                            <label>Telefono:</label>
                            <input type="number" class="form-control">
                        </div>
                        <div class="form-group">
                            <label>Compañia</label>
                          <asp:TextBox ID="txtcmpnm" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>                        
                    </div>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <label>Subject *</label>
                            <asp:TextBox ID="txtsubject" runat="server" CssClass="form-control" ></asp:TextBox>
                            
                        </div>
                        <div class="form-group">
                            <label>Mensaje *</label>
                            <asp:TextBox ID="txtmsg" runat="server" CssClass="form-control"  Rows="8" TextMode="MultiLine"></asp:TextBox>
                           
                        </div>                        
                        <div class="form-group">
                            <asp:Button CssClass="boton_azul" ID="btnEnviarContacto" runat="server" Text="Enviar" />
                        </div>
                    </div>
                </form> 
            </div><!--/.row-->
        </div><!--/.container-->
    </section>
    <!--/#contact-page-->





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
                        <h3>OnTour</h3>
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
                    &copy; 2018 <a target="_blank" href="http://aspxtemplates.com/" title="">OnTour +</a>. All Rights Reserved.
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