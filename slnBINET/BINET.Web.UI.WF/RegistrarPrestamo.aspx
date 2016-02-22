<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="RegistrarPrestamo.aspx.cs" Inherits="BINET.Web.UI.WF.RegistrarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>&nbsp;Registrar Préstamo</h4>
    <hr />
    <div style="width:100%">
        <div style="width:600px;margin:0 auto;">
                <div id="divPromo" class="mensaje-success" style="width:100%;margin:0 auto;" runat="server"></div>
                <table class="table table-condensed">
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:RadioButton ID="rbOpc1" runat="server" GroupName="opciones" Text="Opción 1" />
                        </td>
                        <td>
                            <asp:RadioButton ID="rbOpc2" runat="server" GroupName="opciones" Text="Opción 2" />
                        </td>
                        <td>
                            <asp:RadioButton ID="rbOpc3" runat="server" GroupName="opciones" Text="Opción 3" />
                        </td>
                    </tr>
                    <tr>
                        <td>Moneda</td>
                        <td>
                            <asp:Label ID="moneda1" runat="server" Text="[Ninguno]"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="moneda2" runat="server" Text="[Ninguno]"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="moneda3" runat="server" Text="[Ninguno]"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Monto del Préstamo</td>
                        <td>
                            <asp:Label ID="montotot1" runat="server" Text="0.00"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="montotot2" runat="server" Text="0.00"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="montotot3" runat="server" Text="0.00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Plazo en Meses</td>
                        <td>
                            <asp:Label ID="cuotas1" runat="server" Text="0"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="cuotas2" runat="server" Text="0"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="cuotas3" runat="server" Text="0"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Cuota Mensual</td>
                        <td>
                            <asp:Label ID="montoc1" runat="server" Text="0.00"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="montoc2" runat="server" Text="0.00"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="montoc3" runat="server" Text="0.00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Taza Electiva Anual (TEA) a 360 días</td>
                        <td>
                            <asp:Label ID="tea1" runat="server" Text="0.00"></asp:Label>
                            %</td>
                        <td>
                            <asp:Label ID="tea2" runat="server" Text="0.00"></asp:Label>
                            %</td>
                        <td>
                            <asp:Label ID="tea3" runat="server" Text="0.00"></asp:Label>
                            %</td>
                    </tr>
                    <tr>
                        <td>Taza de Costo Efectivo Anual (TCEA)</td>
                        <td>
                            <asp:Label ID="tcea1" runat="server" Text="0.00"></asp:Label>
                            %</td>
                        <td>
                            <asp:Label ID="tcea2" runat="server" Text="0.00"></asp:Label>
                            %</td>
                        <td>
                            <asp:Label ID="tcea3" runat="server" Text="0.00"></asp:Label>
                            %</td>
                    </tr>
                    <tr>
                        <td>Cuenta de Abono del Préstamo</td>
                        <td colspan="3">
                            <asp:DropDownList ID="cboCuenta" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>Datos de Contacto</td>
                        <td>Teléfono</td>
                        <td>
                            <asp:Label ID="lbltelefono" runat="server" Text="[Ninguno]"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>Correo</td>
                        <td>
                            <asp:Label ID="lblcorreo" runat="server" Text="[Ninguno]"></asp:Label>
                        </td>
                    </tr>
                    <tr align="right">
                        <td colspan="4">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnCancelar_Click" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Continuar" CssClass="btn btn-default" OnClick="btnAceptar_Click" />
                        </td>
                    </tr>
                </table>
        </div>
    </div>
    
</asp:Content>
