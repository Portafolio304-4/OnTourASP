<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iniciarSesion.aspx.cs" Inherits="Mantenedores.iniciarSesion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js" type="text/javascript"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Iniciar Sesion | OnTour</title>
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

        <%-- header--%>

        <div style="background-color: #EEEEF2" class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">

                <center><a href="index.aspx"><img src="imagenes/onTour.png"  height="" width="" /></a></center>

            </div>
            <div class="col-md-1"></div>
        </div>
        <br />
        <%-- cuerpo--%>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4">

                <center> 
            <div class="form-group">
                <center><label for="nombreUsuario">Usuario:</label></center>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtUsuario" runat="server" ErrorMessage="Debe ingresar un usuario"></asp:RequiredFieldValidator>
                <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <center><label for="contraseña">Contraseña:</label></center>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPassword" runat="server" ErrorMessage="Debe ingresar una Contraseña"></asp:RequiredFieldValidator>
                <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            <br /><br /><br />
            <asp:Button CssClass="boton_azul" ID="btnIniciarSesion" runat="server" Text="iniciar Sesion" OnClick="btnIniciarSesionLista_Click" />
                   <br />    <br /> 
            <asp:Button CssClass="boton_azul" ID="btnRegistro" runat="server" Text="Registrarme" OnClick="btnRegistarseLista_Click" CausesValidation="False" />

               </center>

            </div>
            <div class="col-md-4"></div>
        </div>

        <br />



        <%--pie de pagina--%>
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
                    </div>
                    <!--/.col-md-3-->

                    <div class="col-md-3 col-sm-6">
                        <div class="widget">
                            <h3>Soporte</h3>
                            <ul>
                                <li><a href="#">Faq</a></li>

                                <li><a href="#">Documentacion</a></li>


                            </ul>
                        </div>
                    </div>
                    <!--/.col-md-3-->
                    <div class="col-md-3 col-sm-6">
                        <div class="widget">
                            <h3>OnTour</h3>
                            <ul>
                                <li><a href="#">Home</a></li>

                                <li><a href="#">Proyecto</a></li>
                                <li><a href="#">OnTour</a></li>


                            </ul>
                        </div>
                    </div>
                    <!--/.col-md-3-->




                </div>
            </div>
        </section>
        <!--/#bottom-->
        <footer id="footer" class="midnight-blue">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6">
                        &copy; 2018 <a target="_blank" href="http://aspxtemplates.com/" title="">OnTour</a>. All Rights Reserved.
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