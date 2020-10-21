<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <h2 style="color:white" ><%: Title %>.</h2>
    <h3 class=".text-warning" style="color: #FFFFFF" >Hernan Villalba.</h3>
    <address>
        <div>
            <strong class="text" style="color: #FFFFFF">Perfil en <a class=".alert-link" href="https://www.linkedin.com/in/hernangvillalba/" role="button">LinkedIn</a> </strong> <br />
            <strong class="text" style="color: #FFFFFF">Proyectos en </strong><a role="button" class=".alert-link" href="https://github.com/HernanVillalba?tab=repositories">GitHub</a><br />
            <strong class="text" style="color: #FFFFFF">Correo: </strong><a role="button" class=".alert.link" href="mailto:villalbahernan111@gmail.com">HernanVi@gmail.com</a>
        </div>
    </address>

    <h3 style="color: #FFFFFF">Oscar Bianchi.</h3>
    <address style="color: #FFFFFF"> 
        <strong class="text" style="color: #FFFFFF">Perfil en </strong><a class=".alert-link" role="button" href="https://www.linkedin.com/in/oscar-alberto-bianchi-di-rocco-512280163/">LinkedIn</a><br />
        <strong class="text" style="color: #FFFFFF">Proyectos en </strong><a class=".alert-link" role="button" href="https://github.com/oskiman18">GitHub</a><br />
        <strong class="text">Correo: </strong><a role="button" class=".alert.link" href="mailto:oscar__180894@hotmail.com">oscar__180894@hotmail.com</a>

    </address>

    <a class="btn btn-primary" href="Default.aspx">Volver</a>
</asp:Content>
