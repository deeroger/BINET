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
                <div id="divG" style="width:400px;margin:0 auto;">
                    <asp:GridView ID="gvCuenta" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="400px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="TipoDes" HeaderText="Tipo de Cuenta" >
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="MonedaDes" HeaderText="Tipo de Moneda" >
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="disponible" HeaderText="Saldo Disponible" DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </div>
                
                <%--<table class="table table-condensed">
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
              </table>--%>
              <br />
              <div id="divPromo" class="mensaje-success" style="width:400px;margin:0 auto;" runat="server">
                  
              </div>
          </div>  
        </div>
</asp:Content>
