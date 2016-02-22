<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="MostrarCronograma.aspx.cs" Inherits="BINET.Web.UI.WF.MostrarCronograma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>&nbsp;Cronograma de Pago</h4>
    <hr />
    <div style="width:100%">
            <div style="width:600px;margin:0 auto;overflow:auto;height:300px">
                <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="cuota" HeaderText="Periodo" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fecha" HeaderText="Fecha de Pago" DataFormatString="{0:d}" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="monto" HeaderText="Monto" DataFormatString="{0:N2}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="estado" HeaderText="Estado" >
                        <ItemStyle HorizontalAlign="Center" />
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
                <%--<table class="table table-condensed">
                <thead>
                  <tr>
                    <th>Periodo</th>
                    <th>Fecha Pago</th>
                    <th>Pendiente de Pago</th>
                    <th>Cuota Mensual</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>1</td>
                    <td style="text-align:center">01/01/2015</td>
                    <td style="text-align:center">Cumplió</td>
                    <td style="text-align:right">1000.00</td>
                  </tr>
                  <tr>
                    <td>2</td>
                    <td style="text-align:center">01/02/2015</td>
                    <td style="text-align:center">Cumplió</td>
                    <td style="text-align:right">2000.00</td>
                  </tr>
                  <tr>
                    <td>3</td>
                    <td style="text-align:center">01/03/2015</td>
                    <td style="text-align:center">Cumplió</td>
                    <td style="text-align:right">3000.00</td>
                  </tr>  
                  <tr>
                    <td>4</td>
                    <td style="text-align:center">01/04/2015</td>
                    <td style="text-align:center">Pendiente</td>
                    <td style="text-align:right">4000.00</td>
                  </tr>
                  <tr>
                    <td>5</td>
                    <td style="text-align:center">01/05/2015</td>
                    <td style="text-align:center">Pendiente</td>
                    <td style="text-align:right">5000.00</td>
                  </tr>
                  <tr>
                    <td>6</td>
                    <td style="text-align:center">01/06/2015</td>
                    <td style="text-align:center">Pendiente</td>
                    <td style="text-align:right">6000.00</td>
                  </tr>   
                </tbody>
              </table>--%>
          </div>  
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
    </div>
</asp:Content>
