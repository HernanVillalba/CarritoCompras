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
        <h1 class="display-5" style="resize: both;">Herosky - Mancos y asociados</h1>
        <p class="lead">Los mejores precios los conseguís acá!</p>
        <hr class="my-5">
        <p class="lead">
            <asp:TextBox ID="tbBuscar" runat="server" />
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        </p>
    </div>
    


    <div class="row">
        <%
            if (((List<Dominio.Articulos>)Session["busqueda"]).Count() == 0)
            {

                foreach (Dominio.Articulos item in ListArt)
                {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem; background-color: transparent; color: #FFFFFF;">
                <img src="<%= item.Imagen %>" class="card-img-top" alt="Sin imagen" height="180" width="180" onclick="btnDetalles_Click" style="background-color:white">
                <div class="card-body">
                    <h5 class="card-title" style="color: #FFFFFF"><%= item.Nombre %></h5>
                    <p class="card-text" style="color: #FFFFFF">$<%=item.Precio%></p>
                    <a Class="btn btn-primary" href="Detalles.aspx?IDArticulo=<%=item.Id.ToString()%>" style="background-color:deepskyblue;"> Detalles </a>
                    <a class="btn btn-primary" href="Chango.aspx?IDsrc=<%=item.Id.ToString()%>&agregar=1" style="background-color:deepskyblue">Agregar</a>
                </div>
            </div>
        </div>
        <%}
            }%>
          <% 

              else
              {
                  foreach (Dominio.Articulos item in ((List<Dominio.Articulos>)Session["busqueda"]))
                  {%>
        <div class="col-md-4">
            <div class="card" style="width: 18rem; background-color: transparent; color: #FFFFFF;">
                <img src="<%= item.Imagen %>" class="card-img-top" alt="Sin imagen" height="180" width="180" onclick="btnDetalles_Click" style="background-color:white">
                
                    <div class="card-body">
                    <h5 class="card-title" style="color: #FFFFFF"><%= item.Nombre %></h5>
                    <p class="card-text" style="color: #FFFFFF">$<%=item.Precio%></p>
                    <a Class="btn btn-primary" href="Detalles.aspx?IDArticulo=<%=item.Id.ToString()%>" style="background-color:deepskyblue;"> Detalle </a>
                    <a class="btn btn-primary" href="Chango.aspx?IDsrc=<%=item.Id.ToString()%>" style="background-color:deepskyblue">Agregar</a>

                    </div>
            </div>
        </div>
        <%}
            }%>
    </div>
</asp:Content>
