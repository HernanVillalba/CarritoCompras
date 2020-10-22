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
    public partial class InicioWeb : System.Web.UI.Page
    {
        public List<Articulos> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //datagriedview
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.Listar();

        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalles.aspx");
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }
    }
}