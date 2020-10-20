using Dominio;
using Negocio;
using System;
using System.Collections.Generic;

namespace WebForm
{
    public partial class Detalles : System.Web.UI.Page
    {
        public Articulos articuloDetalles { set; get; }

        public List<Articulos> ListaArticulosDetalles { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> ListaAux;
            try
            {
                if (Request.QueryString["IDArticulo"] == "") { Response.Redirect("Articulos.aspx"); }

                ListaAux = negocio.Listar();
                int IDAux = Int32.Parse(Request.QueryString["IDArticulo"]);
                articuloDetalles = ListaAux.Find(i => i.Id == IDAux);
                if (articuloDetalles == null) { Response.Redirect("Articulos.aspx"); }

            }
            catch (Exception ex)
            {
                Response.Redirect("Articulos.aspx");

                throw;
            }
        }
    }
}