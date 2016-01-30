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
                        <td>OLGA ZAMBRANO AGUILAR</td>
                    </tr>
                    <tr>
                        <td>Número de Operación</td>
                        <td>45678905678998765</td>
                    </tr>
                    <tr>
                        <td>N° Cuenta de Tarjeta</td>
                        <td>191-9339-7688-6546-5454</td>
                    </tr>
                    <tr>
                        <td>N° Cuenta Préstamo</td>
                        <td>191-9339-3434-9999-7686</td>
                    </tr>
                    <tr>
                        <td>Cuenta de Abono del Préstamo</td>
                        <td>191-9339-3434-6546-7686</td>
                    </tr>
                    <tr>
                        <td>Importe del Préstamo</td>
                        <td>100,000.00</td>
                    </tr>
                    <tr>
                        <td>TEA a 360 días</td>
                        <td>12.50%</td>
                    </tr>
                    <tr>
                        <td>Número de Cuotas Mensuales</td>
                        <td>36</td>
                    </tr>
                    <tr>
                        <td>Importe Referencial de la Cuota</td>
                        <td>S/. 34350.00</td>
                    </tr>
                    <tr>
                        <td>Fecha y Hora de Operación</td>
                        <td>30/01/2016 - 03:00:00 a.m.</td>
                    </tr>
                    <tr align="right">
                        <td colspan="4">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnCancelar_Click" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Imprimir" CssClass="btn btn-default" OnClick="btnAceptar_Click" />
                        </td>
                    </tr>
                </table>
        </div>
    </div>
</asp:Content>
