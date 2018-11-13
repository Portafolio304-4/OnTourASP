<%@ Page Title="" Language="C#" MasterPageFile="~/maestraDueño.Master" AutoEventWireup="true" CodeBehind="estadoAvance.aspx.cs" Inherits="Mantenedores.estadoAvance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <center><h1>Estado Avance</h1></center>
    <hr />
    <br />


    <div class="row">
        <div class="col-md-1"></div>


        <div class="col-md-10">

        <div class="row">
            <div class="col-md-4"><label>Colegio:</label></div>
            <div class="col-md-4"><asp:DropDownList ID="DropColegio" runat="server"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>

        <div class="row">
            <div class="col-md-4"><label>Curso:</label></div>
            <div class="col-md-4"><asp:DropDownList ID="dropCurso" runat="server"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>

        
        <div class="row">
            <div class="col-md-4"></div>
            
            <div class="col-md-4">
               <center><asp:Button class="boton_azul" ID="btnEstadoAvance" runat="server" Text="Buscar" /></center> 
                
            </div>
            <div class="col-md-4"></div>

        </div>

    </div>
        <div class="col-md-1"></div>
        </div>

    <br /><br /><br />


</asp:Content>
