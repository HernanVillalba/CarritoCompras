using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Detalles : System.Web.UI.Page
    {
        public Articulos articuloDetalles { set; get; }

        public List<Articulos> ListaArticulosDetalles { set; get; }
        private Detalles()
        {
            articuloDetalles = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> ListaAux;
            try
            {
                if(Request.QueryString["IDArticulo"] == "") { Response.Redirect("Articulos.aspx"); }
                
                ListaAux = negocio.Listar();
                int IDAux = Int32.Parse( Request.QueryString["IDArticulo"]);
                articuloDetalles = ListaAux.Find(i => i.Id == IDAux);
                if(articuloDetalles == null) { Response.Redirect("Articulos.aspx"); }
                
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");

                throw;
            }
        }
    }
}