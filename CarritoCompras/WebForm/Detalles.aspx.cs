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
        public Articulos art { set; get; }
        public List<Articulos> ListaArticulos { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> listaAux;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}