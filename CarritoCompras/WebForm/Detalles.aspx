<%@ Page Title="Detalles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="WebForm.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 ><%:Title %></h2>

    <div class="card" style="width: 18rem; background-color: transparent;">
        <img class="card-img-top" src="<%= articuloDetalles.Imagen %>" alt="Card image cap">
        <div class="card-body">
            <ul class="list-group">
                <li class="list-group-item list-group-item-white"><%= articuloDetalles.Nombre %></li>
            </ul>
        </div>
        <div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item list-group-item-white">Código <p style="color:blue;"><%= articuloDetalles.Codigo %></p> </li>

                <li class="list-group-item list-group-item-white">Descripción <p style="color:blue;"><%= articuloDetalles.Descripcion %></p> </li>
                <li class="list-group-item list-group-item-white">Categoria <p style="color:blue;"> <%= articuloDetalles.categoria %> </p> </li>
                <li class="list-group-item list-group-item-white">Marca <p style="color:blue;"> <%= articuloDetalles.Marca %></p> </li>
            </ul>
        </div>
        <div class="btn-group">
            <a href="Articulos.aspx" class="btn btn-primary" style="background-color: deepskyblue;" type="button">Volver</a>
            <a href="Chango.aspx?IDArticulo=<%= articuloDetalles.Id %>" class="btn btn-primary" type="button">Agregar al Carrito</a>
        </div>
    </div>
</asp:Content>
