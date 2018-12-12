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
            <div class="col-md-4"><asp:DropDownList ID="dropRutAlumno" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropRutAlumno_SelectedIndexChanged"></asp:DropDownList></div>
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
    <center><asp:GridView ID="gvActividadesAlumno" runat="server" Text="Resumen Pagos del alumno" CellPadding="4" ForeColor="#333333" GridLines="None" Height="126px" Width="430px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView></center>
    <b><center><asp:Label ID="lblInfo" runat="server" Text="** Los valores de esta tabla son los montos por actividad que corresponden al alumno" Visible="false"></asp:Label></center></b>
    <br />
    <br />
    <h3><center><asp:Label ID="lblResumenPagos" runat="server" Text="Resumen Pagos del alumno" Visible="false"></asp:Label></center></h3>
    <center><asp:GridView ID="gvPagoAlumno" runat="server" Text="Resumen Pagos de actividades" CellPadding="4" ForeColor="#333333" GridLines="None" Height="119px" Width="455px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView></center>
    <br /><br /><br /> 


</asp:Content>
