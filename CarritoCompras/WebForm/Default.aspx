<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card mb-3">
        <img class="card-img-top" src="https://www.computerworld.es/archivos/201909/code.jpg" alt="sin imagen">
        <div class="card-body">
            <h5 class="card-title">Carrito de Productos</h5>
            <p class="card-text">Trabajo práctico para la asignatura 'Programación III' de la UTN - FRGP.</p>
            <p class="card-text">Profesor: Maximiliano Sar Fernandez.</p>
            <ul class="list-group">
                <li class="list-group-item list-group-item-white">
                    <div class="btn-group" role="group" aria-label="Basic example">
                        <div style="vertical-align">

                            <a href="https://maxiprograma.com/">
                                <img src="https://image.flaticon.com/icons/png/512/2641/2641990.png" width="80" height="80" alt="maxiprograma" />
                            </a>

                            <a class="navbar-brand" href="https://www.youtube.com/channel/UCRHzElEnj-QzNOL7LoTIqOQ">
                                <img src="https://image.flaticon.com/icons/png/512/48/48968.png" width="80" height="80" alt="youtube">
                            </a>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>

</asp:Content>
