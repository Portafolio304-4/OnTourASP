<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorOficina.aspx.cs" Inherits="Mantenedores.mantenedorOficina" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Container">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="bandera" runat="server" Text="Insertando" Visible="false"></asp:Label>
            </div>
            <div class="col-lg-10">
                <div class="row">
                    <div class="col-md-5 col-md-offset-4">
                        <h1>Mantenedor Oficina</h1>
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-6 col-lg-offset-2">
                        <table class="table table-hover table-responsive table-sm">
                            <thead></thead>
                            <tbody>
                                <tr>
                                    <td>Empresa</td>
                                    <td><asp:DropDownList ID="dropEmpresa" AutoPostBack="true" runat="server" OnSelectedIndexChanged="dropEmpresa_SelectedIndexChanged"></asp:DropDownList></td>
                                    <td>Sucursal</td>
                                    <td><asp:DropDownList ID="dropSucursal" AutoPostBack="true" runat="server" OnSelectedIndexChanged="dropSucursal_SelectedIndexChanged"></asp:DropDownList></td>
                                    <td>Piso</td>
                                    <td><asp:DropDownList ID="dropPiso" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td>Area</td>
                                    <td><asp:DropDownList ID="dropArea" AutoPostBack="true" runat="server"></asp:DropDownList></td>                                    
                                    <td>Codigo Oficina</td>
                                    <td><asp:TextBox ID="txtCodigoOficina" runat="server"></asp:TextBox></td>                                    
                                    <td>Descripcion</td>
                                    <td><asp:TextBox ID="txtDescripcionOficina" runat="server"></asp:TextBox></td>                                                                        
                                </tr>    
                                <tr>
                                    <td></td>
                                    <td></td>                                    
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigoOficina" ValidationGroup="validacionOficina" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>                                   
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtDescripcionOficina" ValidationGroup="validacionOficina" runat="server" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td>ID Beacons</td>
                                    <td><asp:TextBox ID="txtIdBeacons" runat="server"></asp:TextBox></td>
                                    <td>Video</td>
                                    <td> <asp:TextBox ID="txtVideo" runat="server"></asp:TextBox></td>
                                    <td>Audio</td>
                                    <td> <asp:TextBox ID="txtAudio" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtIdBeacons" ValidationGroup="validacionOficina" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtVideo" ValidationGroup="validacionOficina" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAudio" ValidationGroup="validacionOficina" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                     
                <div class="row">
                    <div class="col-md-4 col-md-offset-5">
                        <asp:Button CssClass="boton_azul" ValidationGroup="validacionOficina" CausesValidation="true" ID="btnGuardarCambios" runat="server" Text="Guardar Cambios" OnClick="btnGuardarCambios_Click" />
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-2 col-lg-offset-2">
                        <asp:Label ID="lblBuscar" runat="server" Text="Buscar Por Codigo Piso"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-lg-2 col-lg-offset-2">
                            <asp:TextBox ID="txtBuscarCodigoOficina" runat="server" Wrap="true"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarCodigoOficina" ForeColor="Red" ValidationGroup="validacionBuscarOficina"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3 ">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarOficina" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click"></asp:Button>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-10 col-lg-offset-1">
                        <asp:GridView ID="gvOficina" runat="server" AutoGenerateColumns="false">
                            <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White" />
                            <Columns>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                                    <ItemTemplate>
                                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click"  />
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click"  />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CodOficina" HeaderStyle-Width="150px" HeaderText="Codigo Oficina" />
                                <asp:BoundField DataField="Empresa" HeaderStyle-Width="180px" HeaderText="Empresa" />
                                <asp:BoundField DataField="Sucursal" HeaderStyle-Width="120px" HeaderText="Sucursal" />
                                <asp:BoundField DataField="Piso" HeaderStyle-Width="150px" HeaderText="Piso" />
                                <asp:BoundField DataField="Area" HeaderStyle-Width="150px" HeaderText="Area" /> 
                                <asp:BoundField DataField="DesOficina" HeaderStyle-Width="150px" HeaderText="Oficina" /> 
                                <asp:BoundField DataField="IdBeacons" HeaderStyle-Width="150px" HeaderText="Id Beacons" />
                                <asp:BoundField DataField="Video" HeaderStyle-Width="150px" HeaderText="Ruta Video" />
                                <asp:BoundField DataField="Audio" HeaderStyle-Width="150px" HeaderText="Ruta Audio" />
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
</asp:Content>
