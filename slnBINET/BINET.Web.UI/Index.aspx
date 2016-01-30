<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BINET.Web.UI.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <div id="content">
        <table style="width:100%;">
            <tr>
                <td style="width:30%;padding:10px;">
                    <br />
                    <div id="login">
                <section id="loginForm">
                    <div class="form-horizontal">
                        <h4>Inicio de Sesión</h4>
                        <hr />
                          <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="FailureText" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="txtUserName" CssClass="col-md-2 control-label">Usuario</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName"
                                    CssClass="text-danger" ErrorMessage="El campo Usuario es requerido" />
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-2 control-label">Contraseña</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" CssClass="text-danger" ErrorMessage="El campo Contraseña es requerido" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button runat="server" OnClick="LogIn" Text="Iniciar Sesión" CssClass="btn btn-default" />
                            </div>
                        </div>
                    </div>
                </section>
            </div>
                </td>
                <td style="vertical-align:top;width:70%;padding:10px;">
                    <br />
                    <div id="detalle">
                            Bienvenido al Sistema de Banca por INTERNET BINET
                            <br />
                            En este sistema podrá consultar datos de su cuenta y préstamos
                            <br />
                            <br />
                            <b>BINET</b> 
                            <br />
                            <br />
                            <b>Integrantes:</b>
                            <ul>
                                <li>Janet Linares Huacantara</li>
                                <li>Roger Garay Casimiro</li>
                                <li>Hugo Teccsi Veredas</li>
                                <li>Yeltsin Moreno Padilla</li>
                                <li>Pedro Romero Salazar</li>
                            </ul>
                    </div>
                 </td>
            </tr>
        </table>
    </div>
</asp:Content>

