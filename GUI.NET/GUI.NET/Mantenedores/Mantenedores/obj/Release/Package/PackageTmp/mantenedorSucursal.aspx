<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorSucursal.aspx.cs" Inherits="Mantenedores.mantenedorSucursal" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="bandera" runat="server" Text="Insertando" Visible="false"></asp:Label>
            </div>
            <div class="col-lg-10">
                <div class="row">
                    <div class="col-md-5 col-md-offset-4">
                        <h1>Mantenedor Sucursal</h1>
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-8 col-md-pull-2">
                        <table class="table table-hover table-responsive table-sm">
                            <thead></thead>
                            <tbody>
                                <tr>
                                    <td>Empresa</td>
                                    <td><asp:DropDownList AutoPostBack="true" ID="dropEmpresa" runat="server"></asp:DropDownList></td>
                                    <td>Region</td>
                                    <td><asp:DropDownList AutoPostBack="true" ID="dropRegion" runat="server" OnSelectedIndexChanged="dropRegion_SelectedIndexChanged"></asp:DropDownList></td>
                                    <td>Provincia</td>
                                    <td><asp:DropDownList AutoPostBack="true" ID="dropProvincia" runat="server" OnSelectedIndexChanged="dropProvincia_SelectedIndexChanged"></asp:DropDownList></td>
                                    <td>Comuna</td>
                                    <td><asp:DropDownList AutoPostBack="true" ID="dropComuna" runat="server"></asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td>Codigo Sucursal</td>
                                    <td> <asp:TextBox ID="txtCodigoSucursal" runat="server"></asp:TextBox></td>
                                    <td>Nombre Sucursal</td>
                                    <td><asp:TextBox ID="txtNombreSucursal" runat="server"></asp:TextBox></td>
                                    <td>Direccion</td>
                                    <td><asp:TextBox ID="txtDireccionSucursal" runat="server"></asp:TextBox></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCodigoSucursal" ValidationGroup="validacionSucursal" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtNombreSucursal" ValidationGroup="validacionSucursal" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtDireccionSucursal" ValidationGroup="validacionSucursal" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4 col-md-offset-5">
                            <asp:Button ValidationGroup="validacionSucursal" CausesValidation="true" CssClass="boton_azul" ID="btnGuardarCambios" runat="server" Text="Guardar Cambios" OnClick="btnGuardarCambios_Click" />
                        </div>                        
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-lg-2 col-lg-offset-2">
                            <asp:Label ID="lblBuscar" runat="server" Text="Buscar Por Codigo Sucursal"></asp:Label>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-2 col-lg-offset-1">
                                <asp:TextBox ID="txtBuscarCodigoSucursal" runat="server" Wrap="true"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarCodigoSucursal" ForeColor="Red" ValidationGroup="validacionBuscarSucursal"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-3 ">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarSucursal" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"></asp:Button>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click"></asp:Button>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-lg-10 col-lg-offset-1">
                            <asp:GridView ID="gvSucursal" runat="server" AutoGenerateColumns="false">
                                <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White" />
                                <Columns>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                                        <ItemTemplate>
                                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="CodSucursal" HeaderStyle-Width ="165px" HeaderText="Codigo Sucursal" />
                                    <asp:BoundField DataField="Empresa" HeaderStyle-Width ="220px" HeaderText="Empresa" />
                                    <asp:BoundField DataField="Region" HeaderStyle-Width ="220px" HeaderText="Region" />
                                    <asp:BoundField DataField="Provincia" HeaderStyle-Width ="165px" HeaderText="Provincia" />                                    
                                    <asp:BoundField DataField="Comuna" HeaderStyle-Width ="150px" HeaderText="Comuna" />
                                    <asp:BoundField DataField="NomSucursal" HeaderStyle-Width ="150px" HeaderText="Nombre Sucursal" />
                                    <asp:BoundField DataField="Direccion" HeaderStyle-Width ="150px" HeaderText="Direccion" />
                                </Columns>                               
                            </asp:GridView>
                        </div>
                        <div class="col-lg-3 col-lg-offset-4">
                            <asp:Label ID="lblResultadoErroneoBuscar" runat="server" ForeColor="Red" Visible="false" Text="SIN RESULTADOS"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
