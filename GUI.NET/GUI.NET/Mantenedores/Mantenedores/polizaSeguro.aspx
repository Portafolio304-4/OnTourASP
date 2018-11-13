<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMantenedores.Master" AutoEventWireup="true" CodeBehind="polizaSeguro.aspx.cs" Inherits="Mantenedores.polizaSeguro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <center><h1>Poliza Seguro</h1></center>
    <hr />
    <br />


    <div class="row">
        <div class="col-md-1"></div>


        <div class="col-md-10">

            <div class="row">
                <div class="col-md-4">
                    <asp:RadioButton ID="rbPolizaSimple" runat="server" GroupName="polizas" Text="Poliza Simple" Checked="true" />

                </div>
                <div class="col-md-4">
                    <asp:RadioButton ID="rbPolizaCompleja" runat="server" GroupName="polizas" Text="Poliza Compleja" />

                </div>
                <div class="col-md-4">
                    <asp:RadioButton ID="rbPolizaTotal" runat="server" GroupName="polizas" Text="Poliza Cobertura Total" />

                </div>

            </div>

            <div class="row">
                <div class="col-md-4">
                    <div class="form-group">
                        <label for="txtNumPasajeros">Numero Pasajeros:</label>
                        <asp:RangeValidator ID="txtNumPasajerosValidator" runat="server" ErrorMessage="El numero de pasasjero debe estar entre 1 y 60" ControlToValidate="txtNumPasajeros" MaximumValue="60" MinimumValue="1"></asp:RangeValidator>
                        <asp:TextBox CssClass="form-control" ID="txtNumPasajeros" runat="server" TextMode="Number">0</asp:TextBox>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label for="dpDayStart">Fecha Partida:</label>
                        <asp:TextBox CssClass="form-control" ID="dpDayStart" runat="server" TextMode="Date"></asp:TextBox>
                    </div>


                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label for="dpDayEnd">Fecha Retorno:</label>
                        <asp:TextBox CssClass="form-control" ID="dpDayEnd" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-4">

                        <asp:Label ID="Label1" runat="server" Text="Cantidad Dias:"></asp:Label>

                    </div>
                    <div class="col-md-4">
                        <asp:Label ID="lblCantidadDias" runat="server" Text=""></asp:Label>

                    </div>
                    <div class="col-md-4">
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-4">

                        <asp:Label ID="Label2" runat="server" Text="Total por persona:"></asp:Label>

                    </div>
                    <div class="col-md-4">

                        <asp:Label ID="lblTotalPersona" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="col-md-4">
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-4">

                        <asp:Label ID="Label3" runat="server" Text="Total a Pagar:"></asp:Label>

                    </div>
                    <div class="col-md-4">
                        <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>

                    </div>
                    <div class="col-md-4">
                    </div>

                </div>


                <center><asp:Label ID="lblValorPoliza" runat="server" Text=""></asp:Label></center>
                <center><asp:Button class="boton_azul" ID="btnBuscarPoliza" runat="server" Text="Buscar" OnClick="btnBuscarPoliza_Click"  /></center>

            </div>

        </div>
        <div class="col-md-1"></div>
    </div>

    <br />
    <br />
    <br />


</asp:Content>
