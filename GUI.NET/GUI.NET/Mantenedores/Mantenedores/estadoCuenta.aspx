<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="estadoCuenta.aspx.cs" Inherits="Mantenedores.estadoCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <br />
    <center><h1>Estado de Cuenta</h1></center>
    <hr />
    <br />
    <center><asp:Label ID="lblResultado" runat="server" Text=""></asp:Label></center>

    <div class="row">
        <div class="col-md-1"></div>


        <div class="col-md-10">

        <div class="row">
            <div class="col-md-4"><label>Curso:</label></div>
            <div class="col-md-4"><asp:DropDownList ID="dropCurso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropCurso_SelectedIndexChanged1"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>

        <div class="row">
            <div class="col-md-4">Rut Alumno</div>
            <div class="col-md-4"><asp:DropDownList ID="dropRutAlumno" runat="server" AutoPostBack="True"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>

        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="lblDeudaTotalAlumno" runat="server" Visible="false"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lblTotalPagadoAlumno" runat="server" Visible="false"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lblTotalPorPagarAlumno" runat="server" Visible="false"></asp:Label>
            </div>

        </div>
        <div class="row">
            <div class="col-md-4"></div>
            
            <div class="col-md-4">
               <center><asp:Button class="boton_azul" ID="btnEstadoCuenta" runat="server" Text="Buscar" OnClick="btnEstadoCuenta_Click" /></center> 
                
            </div>
            <div class="col-md-4"></div>

        </div>

    </div>
        <div class="col-md-1">
            
        </div>
        </div>
    <h3><center><asp:Label ID="lblResumenActividades" runat="server" Text="Resumen Pagos de actividades" Visible="false"></asp:Label></center></h3>
    <center><asp:GridView ID="gvActividadesAlumno" runat="server" Text="Resumen Pagos del alumno"></asp:GridView></center>
    <b><center><asp:Label ID="lblInfo" runat="server" Text="** Los valores de esta tabla son los montos por actividad que corresponden al alumno" Visible="false"></asp:Label></center></b>
    <br />
    <br />
    <h3><center><asp:Label ID="lblResumenPagos" runat="server" Text="Resumen Pagos del alumno" Visible="false"></asp:Label></center></h3>
    <center><asp:GridView ID="gvPagoAlumno" runat="server" Text="Resumen Pagos de actividades"></asp:GridView></center>
    <br /><br /><br /> 


</asp:Content>
