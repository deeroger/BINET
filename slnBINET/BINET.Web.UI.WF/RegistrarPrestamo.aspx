<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="RegistrarPrestamo.aspx.cs" Inherits="BINET.Web.UI.WF.RegistrarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>&nbsp;Registrar Préstamo</h4>
    <hr />
    <div style="width:100%">
        <div style="width:600px;margin:0 auto;">
                <table class="table table-condensed">
                    <tr>
                        <td>Moneda</td>
                        <td>Soles</td>
                        <td>Soles</td>
                        <td>Soles</td>
                    </tr>
                    <tr>
                        <td>Monto del Préstamo</td>
                        <td>5,000.00</td>
                        <td>10,000.00</td>
                        <td>15,000.00</td>
                    </tr>
                    <tr>
                        <td>Plazo en Meses</td>
                        <td>12</td>
                        <td>24</td>
                        <td>36</td>
                    </tr>
                    <tr>
                        <td>Cuota Mensual</td>
                        <td>445.41</td>
                        <td>473.01</td>
                        <td>501.80</td>
                    </tr>
                    <tr>
                        <td>Taza Electiva Anual (TEA) a 360 días</td>
                        <td>12.50%</td>
                        <td>12.50%</td>
                        <td>12.50%</td>
                    </tr>
                    <tr>
                        <td>Taza de Costo Efectivo Anual (TCEA)</td>
                        <td>12.99%</td>
                        <td>12.99%</td>
                        <td>12.99%</td>
                    </tr>
                    <tr>
                        <td>Cuenta de Abono del Préstamo</td>
                        <td colspan="3">
                            <asp:DropDownList ID="cboCuenta" runat="server">
                                <asp:ListItem>Seleccione una cuenta</asp:ListItem>
                                <asp:ListItem>Ahorros Soles (191-2223-3434-3434-3434)</asp:ListItem>
                                <asp:ListItem>Ahorros Dólares (191-2223-3434-3434-3434)</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>Datos de Contacto</td>
                        <td>Teléfono</td>
                        <td>05113456787</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>Correo</td>
                        <td>test@upc.edu.pe</td>
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
