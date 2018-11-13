<%@ Page Title="" Language="C#"  EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorArea.aspx.cs" Inherits="Mantenedores.mantenedorArea" %>
<%@ MasterType  virtualPath="~/MasterPageMantenedores.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container">
        <div class="row">
            <div class="col-md-8 col-md-offset-4">
                <h1>Mantenedor Area</h1>
            </div>
            <div class="col-md-1">
                <asp:label id="bandera" runat="server" text="Insertando" visible="false"></asp:label>
            </div>            
        </div>       
        <br />
        <div class="row">
            <div class="col-md-6">
                <table class="table table-hover table-responsive table-sm">
                    <thead></thead>
                    <tbody>
                        <tr>
                            <td>Codigo de Area</td>
                            <td><asp:TextBox ID="txtCodArea" runat="server"></asp:TextBox></td>
                            <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCodArea" ForeColor="Red" ValidationGroup="validacionArea"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>                            
                            <td>Descripcion Area</td>
                            <td><asp:TextBox ID="txtDescripcionArea" runat="server"></asp:TextBox></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtDescripcionArea" ForeColor="Red" ValidationGroup="validacionArea"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>                                                        
                            <td></td>
                            <td></td>
                            <td></td>                        
                        </tr>
                        <tr>                                                        
                            <td>Empresa</td>
                            <td><asp:DropDownList ID="dropEmpresa" AutoPostBack="true" runat="server" OnSelectedIndexChanged="dropEmpresa_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>Sucursal</td>
                            <td><asp:DropDownList ID="dropSucursal" AutoPostBack="true" runat="server" OnSelectedIndexChanged="dropSucursal_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>Piso</td>
                            <td><asp:DropDownList ID="dropPiso" AutoPostBack="true" runat="server"></asp:DropDownList></td>
                            <td></td>
                            <td></td>
                            <td></td>                           
                        </tr>
                        <tr>
                            <td>Id Beacons</td>
                            <td><asp:TextBox ID="txtIdBeacons" runat="server"></asp:TextBox></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtIdBeacons" ForeColor="Red" ValidationGroup="validacionArea"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                            <td>Audio</td>
                            <td> <asp:TextBox ID ="txtAudio" runat="server"></asp:TextBox></td>
                            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtAudio" ForeColor="Red" ValidationGroup="validacionArea"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                            <td>Video</td>
                            <td><asp:TextBox ID ="txtVideo" runat="server"></asp:TextBox></td>
                            <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtVideo" ForeColor="Red" ValidationGroup="validacionArea"  runat="server" ErrorMessage="Falta !"></asp:RequiredFieldValidator></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-3 col-md-offset-5">
                <asp:Button CssClass="boton_azul" ID="btnGuardar" runat="server" ValidationGroup="validacionArea" Text="Guardar Cambios" OnClick="btnGuardar_Click" />
            </div>
        </div>
        <br />
        <br />
         <div class="row">
                    <div class="col-lg-2 col-lg-offset-2">
                        <asp:Label ID="lblBuscar" runat="server" Text="Buscar Por Codigo Area"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-lg-2 col-lg-offset-2">
                            <asp:TextBox ID="txtBuscarCodigoArea" runat="server" Wrap="true"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarCodigoArea" ForeColor="Red" ValidationGroup="validacionBuscarArea"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3 ">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarArea" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"  ></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click" ></asp:Button>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-1">
                        <asp:GridView ID="gvArea" runat="server" AutoGenerateColumns="false">
                            <HeaderStyle BackColor="#337ab7" Font-Bold="true" ForeColor="White"/>
                            <Columns>
                                 <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="250px">
                                    <ItemTemplate>                                        
                                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CodigoArea" HeaderStyle-Width ="165px" HeaderText="Codigo Area" />
                                <asp:BoundField DataField="DescArea" HeaderStyle-Width ="165px" HeaderText="Desc Area" />
                                <asp:BoundField DataField="NomEmpresa" HeaderStyle-Width ="165px" HeaderText="Nombre Empresa " />
                                <asp:BoundField DataField="NomSucursal" HeaderStyle-Width ="165px" HeaderText="Nombre Sucursal" />
                                <asp:BoundField DataField="DesPiso" HeaderStyle-Width ="165px" HeaderText="Descripcion Piso" />
                                <asp:BoundField DataField="idBeacons" HeaderStyle-Width ="165px" HeaderText="ID Beacons" />
                                <asp:BoundField DataField="pathvideo" HeaderStyle-Width ="165px" HeaderText="Ruta Video" />
                                <asp:BoundField DataField="pathaudio" HeaderStyle-Width ="165px" HeaderText="Ruta Audio" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div class="col-lg-3 col-lg-offset-4">
                        <asp:Label ID="lblResultadoErroneoBuscar" runat="server" ForeColor="Red" Visible="false" Text="SIN RESULTADOS"></asp:Label>
                    </div>
                </div>
          </div> 
    <br />
    <br />
</asp:Content>

