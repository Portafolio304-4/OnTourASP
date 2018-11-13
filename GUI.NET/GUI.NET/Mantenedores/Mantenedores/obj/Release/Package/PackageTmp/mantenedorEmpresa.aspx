<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="mantenedorEmpresa.aspx.cs" Inherits="Mantenedores.mantenedorEmpresa" %>
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
                    <div class="col-lg-6 col-lg-offset-4">
                        <h1>Mantenedor Empresa</h1>
                    </div>
                </div>
                <br />
                <br />

                <div class="row">
                    <div class="col-lg-4 col-lg-offset-3">
                        <asp:Label ID="Label1" runat="server" Text="Rut de la Empresa: "></asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtRutEmpresa" runat="server" Height="22px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRutEmpresa" ErrorMessage="Falta!" ForeColor="Red" ValidationGroup="validacionEmpresa"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-4 col-lg-offset-3">
                        <asp:Label ID="Label2" runat="server" Text="Nombre de la Empresa: "></asp:Label>
                    </div>
                    <div class="col-lg-4">
                        <asp:TextBox ID="txtNombreEmpresa" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombreEmpresa" ErrorMessage="Falta!" ForeColor="Red" ValidationGroup="validacionEmpresa"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4 col-lg-offset-3">
                        <asp:Label ID="Label3" runat="server" Text="Activo:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <asp:RadioButtonList ID="listaRadioButtonEmpresa" runat="server">
                            <asp:ListItem Value="1" Text="Si"></asp:ListItem>
                            <asp:ListItem Value="0" Text="No"></asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Elija Uno" ControlToValidate="listaRadioButtonEmpresa" ForeColor="Red" ValidationGroup="validacionEmpresa"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4 col-lg-offset-5">
                        <asp:Button ValidationGroup="validacionEmpresa" CausesValidation="true" CssClass="boton_azul" ID="btnGuardar" runat="server" Text="Guardar Cambios" OnClick="btnGuardar_Click" />
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
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta !" ControlToValidate="txtBuscarPorRut" ForeColor="Red" ValidationGroup="validacionBuscarEmpresa"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3 ">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBuscar" CausesValidation="true" ValidationGroup="validacionBuscarEmpresa" Text="Buscar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnBuscar_Click"></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnCancelar_Click"></asp:Button>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-10 col-lg-offset-2">
                        <asp:GridView ID="gvEmpresa" runat="server" AutoGenerateColumns="false">
                            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                            <Columns>
                                <%--botones de acción sobre los registros...--%>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                                    <ItemTemplate>
                                        <%--Botones de eliminar y editar Empresa...--%>
                                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%--Para Personalizar el nombre de las Columnas...--%>
                                <asp:BoundField DataField="Rut_empresa" HeaderStyle-Width="150px" HeaderText=" Rut de la Empresa" />
                                <asp:BoundField DataField="nom_empresa" HeaderStyle-Width="180px" HeaderText=" Nombre de la Empresa" />
                                <asp:BoundField DataField="estado" HeaderStyle-Width="80px" HeaderText=" Estado" />
                            </Columns>
                        </asp:GridView>
                        <div class="col-lg-3 col-lg-offset-4">
                            <asp:Label ID="lblResultadoErroneoBuscar" runat="server" ForeColor="Red" Visible="false" Text="SIN RESULTADOS"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-1">
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>


