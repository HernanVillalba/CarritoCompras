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
        <div class="lead">
            <label for="inputPassword2" class="sr-only">Busqueda</label>
            <input type="password" class="form-control" id="inputPassword2" placeholder="Busqueda">
            <a class="btn btn-primary" href="#">Buscar</a>
        </div>
    </div>


    <div class="row">
        <%foreach (Dominio.Articulos item in ListaArticulo)
            {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="<%= item.Imagen %>" alt="Card image cap">
                <div class="card-body">
                    <ul class="list-group">
                        <li class="list-group-item list-group-item-white"><%= item.Nombre %></li>
                    </ul>
                    <ul class="list-group">
                        <li class="list-group-item list-group-item-white">$<%= item.Precio %></li>
                    </ul>
                </div>
                <a class="btn btn-primary" href="Detalles.aspx?IDArticulo=<%=item.Id.ToString()%>" style="background-color: deepskyblue;">Detalle </a>
                <asp:Button ID="btnAgregarCarrito" CssClass="btn btn-primary" Text="Agregar al carrito" OnClick="btnAgregarCarrito_Click" runat="server" />
            </div>

        </div>
        <%} %>
    </div>
</asp:Content>
