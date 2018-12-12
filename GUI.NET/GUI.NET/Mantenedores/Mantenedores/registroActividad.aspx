<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="registroActividad.aspx.cs" Inherits="Mantenedores.registroActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <center><h1>Registrar Actividad</h1></center>
    <hr />
    <br />


    <div class="row">
        <div class="col-md-1"></div>


        <div class="col-md-10">
        
        <center><asp:Label ID="lblResultado" runat="server" Text=""></asp:Label></center>
        <center><asp:Label ID="lblDeudaTotal" runat="server" Text=""></asp:Label></center>

        <div class="row">
            <div class="col-md-4"><label>Curso:</label></div>
            <div class="col-md-4"><asp:DropDownList ID="dropCurso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropCurso_SelectedIndexChanged"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>

        <div class="row">
            <div class="col-md-4">Tipo Actividad:</div>
            <div class="col-md-4"><asp:DropDownList ID="dropTipoActividad" runat="server"></asp:DropDownList></div>
            <div class="col-md-4"></div>

        </div>
        <div class="row">
            <div class="col-md-4">Monto Alcanzado:</div>
            <div class="col-md-4"><asp:TextBox ID="txtMontoCancelar" runat="server"></asp:TextBox></div>
            <div class="col-md-4">
                <br />
                <br /><br />
                <asp:Button class="boton_azul" ID="btnPagar" runat="server" Text="Pagar" OnClick="btnPagar_Click" />
                <br /><br />

                <asp:HyperLink ID="hlInicioSesion" runat="server" NavigateUrl="~/portadaUsuario.aspx">Volver</asp:HyperLink>
            </div>

        </div>

    </div>
        <div class="col-md-1"></div>
        </div>

    <br /><br /><br />
    <center><h3>Historico de Actividades</h3></center><br /><br />

    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10">
            <center><asp:GridView ID="gridHistoricoActividades" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="126px" OnSelectedIndexChanged="gridHistoricoActividades_SelectedIndexChanged" Width="500px">
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
        </div>
        <div class="col-md-1"></div>
    </div>
    <br /><br />


</asp:Content>
