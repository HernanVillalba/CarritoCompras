<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chango.aspx.cs" Inherits="WebForm.Chango" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (ListaCarrito.Count() > 0)
        {%>
    <div class="jumbotron">
        <div>
            <span class="badge badge-primary">Cantidad:
                <asp:Label Text="0" ID="lblCantidad" runat="server" /></span>
            <br />
            <span class="badge badge-primary">Total:
                <asp:Label Width="1" Text="0" ID="lblTotal" runat="server" /></span>
        </div>
        <div style="float: right;">
            <a href="Articulos.aspx" class="btn btn-primary">Volver</a>
            <a href="Chango.aspx?empty=1" class="btn btn primary" style="background-color: red; color: white;">Vaciar carrito</a>
        </div>
    </div>
    <%}%>

    <%if ((ListaCarrito.Count() == 0))
        {%>
    <div class="jumbotron">
        <h1 class="display-5" style="resize: both;">No hay articulos agregados. Qué esperas? ;)</h1>
        <div>
            <a href="Articulos.aspx" class="btn btn-primary">Volver</a>
        </div>
    </div>
    <% } %>

    <div class="row">
        <%foreach (Dominio.Articulos item in ListaCarrito)
            {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem; background-color: transparent; color: #FFFFFF;">
                <img src="<%= item.Imagen %>" class="card-img-top" alt="Sin imagen" height="180" width="180" onclick="btnDetalles_Click" style="background-color: white">
                <div class="card-body">
                    <h5 class="card-title" style="color: #FFFFFF"><%= item.Nombre %></h5>
                    <p class="card-text" style="color: #FFFFFF">$<%=item.Precio%></p>
                    <a class="btn btn-primary" href="Chango.aspx?IDsrc=<%=item.Id.ToString()%>&delete=<%=1.ToString() %>" style="background-color: deepskyblue">Eliminar</a>
                </div>
            </div>
        </div>
        <%}%>
    </div>
</asp:Content>
