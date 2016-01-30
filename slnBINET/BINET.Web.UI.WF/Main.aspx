<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="BINET.Web.UI.WF.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
        <br />
        <asp:Menu ID="mnuUsuario" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem Text="Actualizar Datos" Value="Actualizar Datos" NavigateUrl="~/ActualizarDatos.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Consultar Historial de Prestamo" Value="Consultar Historial de Prestamo" NavigateUrl="~/ConsultarHistorialPrestamo.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Cronograma de Pago" Value="Cronograma de Pago" NavigateUrl="~/MostrarCronograma.aspx"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        <br />
        <div style="width:100%">
            <div style="width:600px;margin:0 auto;">
                <table class="table table-condensed">
                <thead>
                  <tr>
                    <th>Tipo</th>
                    <th>Número</th>
                    <th>Línea Disponible</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>Tarjeta de Crédito VISA Dólares</td>
                    <td style="text-align:center">4444-9999-9890-0000</td>
                    <td style="text-align:right">1200.00</td>
                  </tr>
                  <tr>
                    <td>Tarjeta de Crédito MasterCard Dólares</td>
                    <td style="text-align:center">6666-9999-9890-0000</td>
                    <td style="text-align:right">18,000.00</td>
                  </tr>
                  <tr>
                    <td>Tarjeta de Credito VISA Soles</td>
                    <td style="text-align:center">9999-9999-9890-0000</td>
                    <td style="text-align:right">5.00</td>
                  </tr>
                </tbody>
              </table>
              <div id="divPromo" class="mensaje-success" style="width:400px;margin:0 auto;" runat="server">
                  Tienes un Préstamo Efectivo Aprobado por S/. 15,000.00
                  <br />
                  <a href="RegistrarPrestamo.aspx">Solicítalo aqui</a>
              </div>
          </div>  
        </div>
</asp:Content>
