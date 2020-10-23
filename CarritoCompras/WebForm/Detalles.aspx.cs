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
        public Detalles()
        {
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> ListaAux = new List<Articulos>();
            try
            {
                if (Request.QueryString["IDArticulo"] == "" || articuloDetalles == null)
                {
                    Response.Redirect("Articulos.aspx");
                }

                ListaAux = negocio.Listar();
                int IDAux = Convert.ToInt32(Request.QueryString["IDArticulo"]);
                articuloDetalles = ListaAux.Find(i => i.Id == IDAux);
                //articuloDetalles = ListaAux.Find(i => i.Id == Convert.ToInt32(Request.QueryString["IDArticulo"]));

            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");

                throw;
            }
        }
    }
}