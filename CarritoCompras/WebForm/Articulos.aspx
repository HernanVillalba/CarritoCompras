<%@ Page Title="Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="WebForm.InicioWeb" %>

<asp:Content ID="ContentArticulos" ContentPlaceHolderID="MainContent" runat="server">


    <%foreach (Dominio.Articulos item in ListaArticulo)
        {%>
    <div class="card" style="width: 18rem;">
        <img src="<%= item.Imagen %>" class="card-img-top" alt="Sin imagen" height="200">
        <div class="card-body">
            <h5 class="card-title"><%= item.Nombre %></h5>
            <p class="card-text">$<%=item.Precio%></p>
            <asp:Button ID="btnDetalles" CssClass="btn btn-primary" Text="Detalles" OnClick="btnDetalles_Click""Detalles.aspx?key="+"<%item.Id %>" runat="server" />
            <asp:Button ID="btnAgregarCarrito" CssClass="btn btn-primary" Text="Agregar al carrito" OnClick="btnAgregarCarrito_Click" runat="server" />
        </div>
        <%} %>
    </div>
</asp:Content>
