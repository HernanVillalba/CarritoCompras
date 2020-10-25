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
     
        protected void Page_Load(object sender, EventArgs e)
        {
            int IDAux = Convert.ToInt32(Request.QueryString["IDsrc"]);
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> ListaAux =  negocio.Listar();
            try
            {
                if (Request.QueryString["IDsrc"] == "")
                {
                    Response.Redirect("Articulos.aspx");
                }

                
           
                articuloDetalles = ListaAux.Find(i => i.Id == IDAux);
                //articuloDetalles = ListaAux.Find(i => i.Id == Convert.ToInt32(Request.QueryString["IDArticulo"]));

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");

                throw;
            }
        }
    }
}