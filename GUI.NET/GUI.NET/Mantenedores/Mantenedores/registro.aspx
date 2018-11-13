<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Mantenedores.registro" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js" type="text/javascript"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Iniciar Sesion | OpenReality+</title>
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

        <%-- header--%>

        <div style="background-color:#EEEEF2" class="row">
            <div class="col-md-1"></div>
            <div  class="col-md-10">

                <center><a href="index.aspx"><img src="imagenes/onTour.png"  height="" width="" /></a></center>

            </div>
            <div class="col-md-1"></div>
        </div>
        <asp:Label ID="message" runat="server" Text="" Enabled="false"></asp:Label>
        <br />
        <%-- cuerpo--%>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <center>
                    <div class="form-group">
                        <center><label for="colegio">Seleccione Colegio:</label></center>

                        <asp:DropDownList CssClass="form-control" ID="ddlColegio" runat="server" OnSelectedIndexChanged="ddlColegio_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    </div>
                    
                    <div class="form-group">
                        <center><label for="curso">Seleccione Curso:</label></center>

                        <asp:DropDownList CssClass="form-control" ID="ddlCurso" runat="server" AutoPostBack="True"></asp:DropDownList>
                    </div>

                    <div class="form-group">
                    
                        <center><label for="rut">Rut(Este sera su nombre de usuario para conectarse):</label></center>
                        
                        <asp:RequiredFieldValidator ID="reqRutVerification" runat="server" ErrorMessage="Debe Escribir un rut..." ControlToValidate="txtRut" ></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgxRut" runat="server" ErrorMessage="Debe ingresar un rut valido" ControlToValidate="txtRut"  ValidationExpression="^0*(\d{1,3}(\.?\d{3})*)\-?([\dkK])$"></asp:RegularExpressionValidator>
                        <asp:TextBox CssClass="form-control" ID="txtRut" runat="server"></asp:TextBox>
                    </div>
                    

                    <div class="form-group">
                        <center><label for="contrasena">Contraseña:</label></center>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Escribir una contraseña..." ControlToValidate="txtPassword"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                            <div class="form-group">
                       <center><label for="confirmar Contrasena">Confirmar Contraseña:</label></center>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe escribir una contraseña..." ControlToValidate="txtPassword2"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <center><label for="Email">Email:</label></center>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe Escribir un email..." ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        
                        <asp:CheckBox ID="chkEncargado" runat="server" Text="Es Encargado?"/>
 
                    </div>
    
        
                    <asp:Button class="boton_azul" ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" />
            
        
                    <br /><asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                    
                    <br />
           
                    <asp:HyperLink ID="hlInicioSesion" runat="server" NavigateUrl="~/iniciarSesion.aspx">Volver</asp:HyperLink>
               </center>
                

            </div>
            <div class="col-md-4">
            </div>
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
                            <li><a href="#">Home</a></li>
                            
                            <li><a href="#">Proyecto</a></li>
                            <li><a href="#">OnTour</a></li>
                            
                            
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

