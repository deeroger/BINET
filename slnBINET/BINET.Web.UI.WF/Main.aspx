<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="BINET.Web.UI.WF.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
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
                  <a href="#">Solicítalo aqui</a>
              </div>
          </div>  
        </div>
</asp:Content>
