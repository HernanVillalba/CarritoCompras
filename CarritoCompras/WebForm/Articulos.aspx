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

    <div class="jumbotron" style="width:900px; margin-left:auto;margin-right:auto;">
        <h1 class="display-5" style="resize: both;">Herosky - Mancos y asociados</h1>
        <p class="lead">Los mejores precios los conseguís acá!</p>
        <hr class="my-5">
        <p class="lead">
            <asp:TextBox ID="tbBuscar" runat="server"/>
            <asp:Button ID="btnBuscar" runat="server" cssClass="btn btn-primary" OnClick="btnBuscar_Click" Text="Buscar" style="background-color:#51adcf;" />
            <%if (((List<Dominio.Articulos>)Session["busqueda"]).Count() == 0)
                {%>
            <asp:Button ID="btnListar" Onclick="btnListar_Click" cssClass="btn btn-primary" Text="Listar Todo" runat="server" style="background-color:#0f3057;"/>
            <% } %>
        </p>
    </div>

    <asp:ListView ID="dgvArticulos" runat="server"></asp:ListView>

    <div class="row">
        <%
    if (((List<Dominio.Articulos>)Session["busqueda"]).Count() == 0)
         {%>
        <h1 style="color:white"> No hay un Articulo con ese Nombre, intente nuevamente! </h1>
      
        <% }

            else
            {
                foreach (Dominio.Articulos item in ((List<Dominio.Articulos>)Session["busqueda"]))
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
                    <a href="Detalles.aspx?IDsrc=<%= item.Id %>" class="btn btn-primary" style="background-color: deepskyblue;" type="button">Detalles</a>
                    <a href="Chango.aspx?IDsrc=<%= item.Id.ToString()%>&agregar=1" class="btn btn-primary" type="button">Agregar al Carrito</a>
                </div>
            </div>
        </div>
        <%}
    }%>
    </div>
</asp:Content>
