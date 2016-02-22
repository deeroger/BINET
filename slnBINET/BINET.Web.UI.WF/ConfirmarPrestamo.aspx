<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ConfirmarPrestamo.aspx.cs" Inherits="BINET.Web.UI.WF.ConfirmarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>&nbsp;Confirmación de Préstamo</h4>
    <hr />
    <div style="width:100%">
        <div style="width:600px;margin:0 auto;">
                <table class="table table-condensed">
                    <tr>
                        <td>Cliente</td>
                        <td>
                            <asp:Label ID="lblcliente" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Número de Operación</td>
                        <td>
                            <asp:Label ID="lblprestamo" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>N° Cuenta de Tarjeta</td>
                        <td>
                            <asp:Label ID="lbltarjeta" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>N° Cuenta Préstamo</td>
                        <td>
                            <asp:Label ID="lblcuentaorigen" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Cuenta de Abono del Préstamo</td>
                        <td>
                            <asp:Label ID="lblcuentadestino" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Importe del Préstamo</td>
                        <td>
                            <asp:Label ID="lblmonto" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>TEA a 360 días</td>
                        <td>
                            <asp:Label ID="lbltea" runat="server" Text="Label"></asp:Label>
                            %</td>
                    </tr>
                    <tr>
                        <td>Número de Cuotas Mensuales</td>
                        <td>
                            <asp:Label ID="lblcuotas" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Importe Referencial de la Cuota</td>
                        <td>S/
                            <asp:Label ID="lblcuota" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Fecha y Hora de Operación</td>
                        <td>
                            <asp:Label ID="lblfecha" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr align="right">
                        <td colspan="4">
                            <asp:Button ID="btnCancelar" runat="server" Text="Salir" CssClass="btn btn-default" OnClick="btnCancelar_Click" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Imprimir" CssClass="btn btn-default"  OnClientClick="javascript:window.print();return false;" />
                        </td>
                    </tr>
                </table>
        </div>
    </div>
</asp:Content>
