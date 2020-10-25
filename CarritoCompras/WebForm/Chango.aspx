<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chango.aspx.cs" Inherits="WebForm.Chango" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <%if ((ListaCarrito.Count() == 0))
        {%>
    <div class="jumbotron">
        <h1 class="display-5" style="resize: both;">No hay articulos agregados. Qué esperas? ;)</h1>
        <div>
            <a href="Articulos.aspx" class="btn btn-primary">Volver</a>
        </div>
    </div>
    <% } %>

    <%if (ListaCarrito.Count() > 0)
        {%>
    <div class="jumbotron">
        <div>
            <span class="badge badge-primary">Cantidad:
                <asp:Label Text="0" ID="lblCantidad" runat="server" /></span>
            <br />
            <span class="badge badge-primary">Total: $
                <asp:Label Text="0" ID="lblTotal" runat="server" /></span>
        </div>
        <div style="float: right;">
            <a href="Articulos.aspx" class="btn btn-primary">Volver</a>
            <a href="Chango.aspx?empty=1" class="btn btn primary" style="background-color: red; color: white;">Vaciar carrito</a>
        </div>
    </div>
    <%}%>

    <div class="row">
        <%foreach (Dominio.Articulos item in ListaCarrito)
            {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem; background-color: transparent;">
                <img class="card-img-top" src="<%= item.Imagen %>" alt="sin imagen">
                <div class="card-body">
                    <ul class="list-group">
                        <li class="list-group-item list-group-item-white"><%= item.Nombre %></li>
                    </ul>
                </div>
                <div class="btn-group">
                    <a class="btn btn-primary" href="Chango.aspx?IDsrc=<%=item.Id.ToString()%>&delete=<%=1.ToString() %>" style="background-color: deepskyblue">Eliminar</a>
                </div>
            </div>
        </div>
        <%}%>
    </div>
</asp:Content>
