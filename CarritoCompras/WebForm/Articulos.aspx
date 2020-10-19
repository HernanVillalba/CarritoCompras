<%@ Page Title="Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="WebForm.InicioWeb" %>

<asp:Content ID="ContentArticulos" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            margin: 0;
            min-height: 100vh;
            background-image: url(https://i.pinimg.com/originals/a0/4b/23/a04b23beb1b91d4aed1b730140264f26.jpg);
            background-repeat: no-repeat;
            background-size: cover;
            background-position: center;
        }
    </style>

    <div class="jumbotron">
        <h1 class="display-5" style="resize: both;">Heroski - Malvados y asociados</h1>
        <p class="lead">Los mejores precios los conseguís acá!</p>
        <hr class="my-5">
        <p class="lead">
            <asp:TextBox ID="tbBuscar" runat="server" />
            <a class="btn btn-primary btn-lg" href="#" role="button">Buscar</a>
        </p>
    </div>


    <div class="row">
        <%foreach (Dominio.Articulos item in ListaArticulo)
            {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem; background-color: transparent;">
                <img src="<%= item.Imagen %>" class="card-img-top" alt="Sin imagen" height="150" width="180" onclick="btnDetalles_Click">
                <div class="card-body">
                    <h5 class="card-title"><%= item.Nombre %></h5>
                    <p class="card-text">$<%=item.Precio%></p>
                    <a Class="btn btn-primary" href="Detalles.aspx?IDArticulo=<%=item.Id.ToString()%>" style="background-color:deepskyblue;"> Detalle </a>
                    <asp:Button ID="btnAgregarCarrito" CssClass="btn btn-primary" Text="Agregar al carrito" OnClick="btnAgregarCarrito_Click" runat="server" />
                </div>
            </div>
        </div>
        <%} %>
    </div>
</asp:Content>
