<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ActualizarDatos.aspx.cs" Inherits="BINET.Web.UI.WF.ActualizarDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCuerpo" runat="server">
    <div class="form-horizontal">
        <hr />
        <h4>Actualizar Datos</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtApellidos" CssClass="col-md-2 control-label">Apellidos</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNombres" CssClass="col-md-2 control-label">Nombres</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">E-Mail</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtTelefono" CssClass="col-md-2 control-label">Teléfono</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnCancelar_Click" />
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-default" OnClick="btnAceptar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
