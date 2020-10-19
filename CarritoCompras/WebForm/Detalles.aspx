<%@ Page Title="Detalles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="WebForm.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:Title %></h2>

    <div class="card" style="width: 18rem;">
        <img class="card-img-top" src="<%= articuloDetalles.Imagen %>" alt="Card image cap">
        <div class="card-body">
            <h5 class="card-title"><%= articuloDetalles.Nombre %></h5>
            <p class="card-text"><%= articuloDetalles.Descripcion %></p>
        </div>
        <ul class="list-group list-group-flush">
            <p>Código </p>
            <li class="list-group-item"><%= articuloDetalles.Codigo %></li>
            <p>Categoria</p>
            <li class="list-group-item"><%= articuloDetalles.categoria %></li>
            <p>Marca</p>
            <li class="list-group-item"><%= articuloDetalles.Marca %></li>
        </ul>
        <div class="btn-group">
            <a href="Articulos.aspx" class="btn btn-primary" type="button">Volver</a>
            <a href="#" class="btn btn-primary" type="button">Agregar al Carrito</a>
            <button class="btn primary" type="button" onclick="localion.href='Articulos.aspx'">Hola </button>
            <button class="btn primary" type="button">Mundo!</button>
        </div>
    </div>
</asp:Content>
