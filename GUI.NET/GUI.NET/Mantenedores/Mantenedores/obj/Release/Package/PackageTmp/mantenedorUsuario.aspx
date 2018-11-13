<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorUsuario.aspx.cs" Inherits="Mantenedores.mantenedorUsuario" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="bandera" runat="server" Text="Insertando" Visible="false"></asp:Label>
            </div>
            <div class="col-lg-11">
                <div class="row">
                    <div class="col-lg-5 col-lg-offset-4">
                        <h1>Mantenedor de Usuarios</h1>
                    </div>
                </div>
                <br />
                <table class ="table table-hover table-responsive table-sm">
                    <thead></thead>
                    <tbody>
                        <tr>                            
                            <td>Rut Usuario</td>
                            <td><asp:TextBox ID="txtRutUsuario" runat="server" Width="150px"></asp:TextBox></td>
                            <td>Ej 11111111-2</td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtRutUsuario" runat="server" ErrorMessage="Falta !" ForeColor="Red" ValidationGroup="validacionUsuario"></asp:RequiredFieldValidator></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Nombre</td>
                            <td><asp:TextBox ID="txtNombre" runat="server" Width="150px"></asp:TextBox></td>
                            <td>Apellido Paterno</td>
                            <td><asp:TextBox ID="txtApellidoPa" runat="server" Width="150px"></asp:TextBox></td>
                            <td>Apellido Materno</td>
                            <td><asp:TextBox ID="txtApellidoMa" runat="server" Width="150px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtNombre" ValidationGroup="validacionUsuario" runat="server" ErrorMessage="Falta !" ForeColor="Red"></asp:RequiredFieldValidator></td>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtApellidoPa" ValidationGroup="validacionUsuario" runat="server" ErrorMessage="Falta !" ForeColor="Red"></asp:RequiredFieldValidator></td>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtApellidoMa" ValidationGroup="validacionUsuario" runat="server" ErrorMessage="Falta !" ForeColor="Red"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>Num Celular</td>
                            <td><asp:TextBox ID="txtNumeroCelular" runat="server" Width="150px"></asp:TextBox></td>
                            <td>Correo</td>
                            <td><asp:TextBox ID="txtCorreo" runat="server" Width="150px"></asp:TextBox></td>
                            <td>Empresa</td>
                            <td><asp:DropDownList ID="dropEmpresa" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dropEmpresa_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtNumeroCelular" ValidationGroup="validacionUsuario" runat="server" ErrorMessage="Falta!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                            <td></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtCorreo" ValidationGroup="validacionUsuario" runat="server" ErrorMessage="Falta !" ForeColor="Red"></asp:RequiredFieldValidator></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Tipo Discapacidad</td>
                            <td><asp:DropDownList ID="dropTipoDiscapacidad" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                            <td>Codigo de Perfil</td>
                            <td><asp:DropDownList ID="dropPerfil" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                            <td>Sucursal</td>
                            <td><asp:DropDownList ID="dropSucursal" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                        </tr>
                    </tbody>
                </table>
                <br />
                <br />
                <div class="row">
                    <div class="col-md-4 col-md-offset-5">
                        <asp:Button CssClass="boton_azul" ID="btnGuardarCambios" ValidationGroup="validacionUsuario" CausesValidation="true" runat="server" Text="GuardarCambios" OnClick="btnGuardarCambios_Click" />
                    </div>
                </div> 
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-2 col-lg-offset-2">
                        <asp:Label ID="lblBuscar" runat="server" Text="Buscar Por Rut"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-lg-2 col-lg-offset-2">
                            <asp:TextBox ID="txtBuscarPorRut" runat="server" Wrap="true"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarPorRut" ForeColor="Red" ValidationGroup="validacionBuscarUsuario"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3 ">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarUsuario" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click" ></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click" ></asp:Button>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12">
                        <asp:GridView ID="gvUsuario" runat="server" AutoGenerateColumns="false" >
                            <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White"/>
                            <Columns>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                                    <ItemTemplate>                                        
                                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click"  />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="RutUsuario" HeaderStyle-Width ="165px" HeaderText="Rut del Usuario" />
                                <asp:BoundField DataField ="NombreEmpresa" HeaderStyle-Width ="165px" HeaderText="Rut de la Empresa" />
                                <asp:BoundField DataField ="Sucursal" HeaderStyle-Width ="150px" HeaderText="Sucursal" />
                                <asp:BoundField DataField="Perfil" HeaderStyle-Width ="150px" HeaderText ="Perfil" />
                                <asp:BoundField DataField="Discapacidad" HeaderStyle-Width ="150px" HeaderText="Discapacidad" />
                                <asp:BoundField DataField ="ape_paterno" HeaderStyle-Width ="150px" HeaderText="Apellido Paterno" />
                                <asp:BoundField DataField ="ape_materno" HeaderStyle-Width ="150px" HeaderText="Apellido Materno" />
                                <asp:BoundField DataField ="nombres" HeaderStyle-Width ="150px" HeaderText="Nombres" />
                                <asp:BoundField DataField ="num_celular" HeaderStyle-Width ="150px" HeaderText="Celular" />
                                <asp:BoundField DataField ="email" HeaderStyle-Width="150px" HeaderText="Email" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div class="col-lg-3 col-lg-offset-4">
                        <asp:Label ID="lblResultadoErroneoBuscar" runat="server" ForeColor="Red" Visible="false" Text="SIN RESULTADOS"></asp:Label>
                    </div>
                </div>
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>

