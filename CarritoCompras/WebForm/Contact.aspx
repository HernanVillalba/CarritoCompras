<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3 class=".text-warning">Hernan Villalba.</h3>
    <address>
        <div>
            <strong class="text">Perfil en <a class=".alert-link" href="https://www.linkedin.com/in/hernangvillalba/" role="button">LinkedIn</a> </strong> <br />
            <strong>Proyectos en </strong><a class=".alert-link" href="https://github.com/HernanVillalba?tab=repositories">GitHub</a><br />
            <strong>Correo: </strong><a class=".alert-link" href="mailto:villalbahernan111@gmail.com">Contacto@HernanVi.com</a>
        </div>
    </address>

    <h3>Oscar Bianchi</h3>
    <address>
        <strong>Perfil en </strong><a href="https://www.linkedin.com/in/oscar-alberto-bianchi-di-rocco-512280163/">LinkedIn</a><br />
        <strong>Proyectos en </strong><a href="https://github.com/oskiman18">GitHub</a><br />
    </address>

    <a class="btn btn-primary" href="Default.aspx">Volver</a>
</asp:Content>
