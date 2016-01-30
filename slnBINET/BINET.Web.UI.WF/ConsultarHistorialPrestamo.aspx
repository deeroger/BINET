<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ConsultarHistorialPrestamo.aspx.cs" Inherits="BINET.Web.UI.WF.ConsultarHistorialPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <hr />
    <h4>Consultar Historial de Préstamos</h4>
    <hr />
    <div style="width:100%">
            <div style="width:600px;margin:0 auto;">
                <table class="table table-condensed">
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
              </table>
          </div>  
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-default" OnClick="btnRegresar_Click" />
    </div>
</asp:Content>
