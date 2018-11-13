<%@ Page Title="" Language="C#" MasterPageFile="~/maestraDueño.Master" AutoEventWireup="true" CodeBehind="portadaDueño.aspx.cs" Inherits="Mantenedores.portadaDueño" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <center><h1>Bienvenido: </h1> <asp:Label ID="lblNombreBienvenida" runat="server" Text=""></asp:Label></center>
    <hr />
    <br />

<div class="row">

<div class="col-md-1"></div>
<div class="col-md-10"></div>
<div class="col-md-1"></div>
    
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
        <center><img src="imagenes/viajes.jpg" alt="Los Angeles" height="500" width="1000"></center>
    </div>

    <div class="item">
      <center><img src="imagenes/viajes2.jpg" alt="Chicago" height="500" width="1000"></center>
    </div>

    <div class="item">
      <center><img src="imagenes/viajes3.jpg" alt="New York" height="500" width="1000"></center>
    </div>
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>



<div class="col-md-1"></div>

</div>



</asp:Content>
