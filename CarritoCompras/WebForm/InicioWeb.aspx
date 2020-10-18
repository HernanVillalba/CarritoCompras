<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioWeb.aspx.cs" Inherits="WebForm.InicioWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>

    <%/* %>
    <!--
    <div class="card" style="width: 18rem;">
        <img src="<%= item.Imagen %>" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title"><%= item.Nombre %></h5>
            <p class="card-text">$<%=item.Precio%></p>
        </div>
        <a class="btn btn-primary" href="Detalles.aspx">Detalles</a><br />
        <a class="btn btn-primary" href="#">Agregar al carrito</a>
    </div>
    -->
    <%*/ %>


    <%foreach (Dominio.Articulos item in ListaArticulo)
        {%>
    <div class="card" style="width: 18rem;">
        <img src="<%= item.Imagen %>" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title"><%= item.Nombre %></h5>
            <p class="card-text">$<%=item.Precio%></p>
            <a class="btn btn-primary" href="Detalles.aspx">Detalles</a><br />
            <a class="btn btn-primary" href="#">Agregar al carrito</a>
            
        </div>
        <%} %>
    </div>
</asp:Content>
