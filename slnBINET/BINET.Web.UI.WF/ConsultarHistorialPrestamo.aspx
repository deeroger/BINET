<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ConsultarHistorialPrestamo.aspx.cs" Inherits="BINET.Web.UI.WF.ConsultarHistorialPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>Consultar Historial de Préstamos</h4>
    <hr />
    <div style="width:100%">
            <div style="width:600px;margin:0 auto;">
            <div id="divPromo" class="mensaje-success" style="width:100%;margin:0 auto;" runat="server"></div>
            <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%" DataKeyNames="codigo" OnRowCommand="gvData_RowCommand">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="codigo" >
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Fecha de Aprobación" DataField="Fechor" >
                    <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Monto" DataField="monto" DataFormatString="{0:N2}" >
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="TEA" DataField="tea" DataFormatString="{0:N2}" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="TCEA" DataField="tcea" DataFormatString="{0:N2}" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="N° Cuotas" DataField="cuotas" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:CommandField SelectText="Ver detalle" ShowSelectButton="True" />
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
                    <th>Nro</th>
                    <th>Fecha Aprueba préstamo</th>
                    <th>Fecha Pago última cuota</th>
                    <th>Monto S/.</th>
                    <th>Nro de Cuotas</th>
                    <th>Estado</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>1</td>
                    <td style="text-align:center">01/01/2015</td>
                    <td style="text-align:center">01/02/2015</td>
                    <td style="text-align:right">1000.00</td>
                    <td style="text-align:center">4</td>
                    <td style="text-align:center">P</td>
                  </tr>
                  <tr>
                    <td>2</td>
                    <td style="text-align:center">05/07/2015</td>
                    <td style="text-align:center">07/12/2015</td>
                    <td style="text-align:right">15000.00</td>
                    <td style="text-align:center">10</td>
                    <td style="text-align:center">C</td>
                  </tr>
                </tbody>
              </table>--%>
          </div>  
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
    </div>
</asp:Content>
