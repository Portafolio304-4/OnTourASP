<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorRegion.aspx.cs" Inherits="Mantenedores.mantenedorRegion" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <h1>Mantenedor Region</h1>
            </div>
            <div class="col-md-1">
                <asp:Label ID="bandera" runat="server" Text="Insertando" Visible="false"></asp:Label>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-3 col-lg-offset-3">
                <table class="table table-hover table-responsive table-sm">
                    <tr>
                        <td>Nombre Region</td>
                        <td> <asp:TextBox ID="txtNombreRegion" runat="server" ValidationGroup="validacionRegion"></asp:TextBox></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNombreRegion" runat="server" ValidationGroup="validacionRegion" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                        <td>Codigo Region</td>
                        <td><asp:TextBox ID="txtCodigoRegion" runat="server" ValidationGroup="validacionRegion"></asp:TextBox></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCodigoRegion" ValidationGroup="validacionRegion" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                    </tr>
                </table>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-3 col-md-offset-5">
                <asp:Button CssClass="boton_azul" ID="btnGuardar" CausesValidation="true" runat="server" ValidationGroup="validacionRegion" Text="Guardar Cambios" OnClick="btnGuardar_Click" />
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-lg-2 col-lg-offset-2">
                <asp:Label ID="lblBuscar" runat="server" Text="Buscar Por Codigo Region"></asp:Label>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-2 col-lg-offset-1">
                    <asp:TextBox ID="txtBuscarCodigoRegion" runat="server" Wrap="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarCodigoRegion" ForeColor="Red" ValidationGroup="validacionBuscarRegion"></asp:RequiredFieldValidator>
                </div>
                <div class="col-lg-2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarRegion" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"></asp:Button>         
                    <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click"></asp:Button>
                </div>
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2">
                <asp:GridView ID="gvRegion" runat="server" AutoGenerateColumns="false">
                    <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White" />
                    <Columns>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="CodigoRegion" HeaderStyle-Width="165px" HeaderText="Codigo Region" />
                        <asp:BoundField DataField="NombreRegion" HeaderStyle-Width="165px" HeaderText="Nombre Region" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-lg-3 col-lg-offset-4">
                <asp:Label ID="lblResultadoErroneoBuscar" runat="server" ForeColor="Red" Visible="false" Text="SIN RESULTADOS"></asp:Label>
            </div>
        </div>        
    </div>
</asp:Content>
