<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorPiso.aspx.cs" Inherits="Mantenedores.mantenedorPiso" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="bandera" runat="server" Text="Insertando" Visible="false"></asp:Label>
            </div>
            <div class="col-md-10">
                <div class="row">
                    <div class="col-md-4 col-lg-offset-4">
                        <h1>Mantenedor Piso</h1>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-7 col-lg-offset-1">
                        <table class="table table-hover table-responsive table-sm">
                            <thead></thead>
                            <tbody>
                                <tr>
                                    <td>Empresa</td>
                                    <td><asp:DropDownList ID="dropEmpresa" AutoPostBack="true" runat="server" OnSelectedIndexChanged="dropEmpresa_SelectedIndexChanged" ></asp:DropDownList></td>
                                    <td></td>
                                    <td>Sucursal</td>
                                    <td><asp:DropDownList ID="dropSucursal" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>Codigo Piso</td>
                                    <td><asp:TextBox ID="txtCodPiso" runat="server"></asp:TextBox></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCodPiso" ForeColor="Red" ValidationGroup="validacionPiso"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td>Descripcion Piso</td>
                                    <td><asp:TextBox ID="txtDesPiso" runat="server"></asp:TextBox></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtDesPiso" ValidationGroup="validacionPiso" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                </tr>                                
                                <tr>
                                    <td>Id Beacons</td>
                                    <td><asp:TextBox ID="txtIdBeacons" runat="server"></asp:TextBox></td>
                                    <td><asp:RequiredFieldValidator ControlToValidate="txtIdBeacons" ValidationGroup="validacionPiso" ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td>Video</td>
                                    <td><asp:TextBox ID="txtVideo" runat="server"></asp:TextBox></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtVideo" ValidationGroup="validacionPiso" runat="server" ForeColor="Red" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                </tr>                                
                                <tr>
                                    <td>Audio</td>
                                    <td><asp:TextBox ID="txtAudio" runat="server"></asp:TextBox></td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtAudio" ValidationGroup="validacionPiso" ForeColor="Red" runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <br />            
                <div class="row">
                    <div class="col-md-4 col-lg-offset-4">
                        <asp:Button CssClass="boton_azul" ID="btnGuardar" ValidationGroup="validacionPiso" CausesValidation="true" runat="server" Text="Guardar Cambios" OnClick="btnGuardar_Click" />
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
                            <asp:TextBox ID="txtBuscarCodigoPiso" runat="server" Wrap="true"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarCodigoPiso" ForeColor="Red" ValidationGroup="validacionBuscarPiso"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3 ">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarPiso" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"  ></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click" ></asp:Button>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-1">
                        <asp:GridView ID="gvPiso" runat="server" AutoGenerateColumns="false">
                            <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White"/>
                            <Columns>
                                 <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                                    <ItemTemplate>                                        
                                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="codPiso" HeaderStyle-Width ="165px" HeaderText="Codigo Piso" />
                                <asp:BoundField DataField="Empresa" HeaderStyle-Width ="165px" HeaderText="Empresa" />
                                <asp:BoundField DataField="Sucursal" HeaderStyle-Width ="165px" HeaderText="Sucursal " />
                                <asp:BoundField DataField="desPiso" HeaderStyle-Width ="165px" HeaderText="Descripcion Piso" />
                                <asp:BoundField DataField="idBeacons" HeaderStyle-Width ="165px" HeaderText="ID Beacons" />
                                <asp:BoundField DataField="video" HeaderStyle-Width ="165px" HeaderText="Ruta Video" />
                                <asp:BoundField DataField="audio" HeaderStyle-Width ="165px" HeaderText="Ruta Audio" />
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
    <br />
</asp:Content>

