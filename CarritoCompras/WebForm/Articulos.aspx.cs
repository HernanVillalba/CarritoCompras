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
        public List<Articulos> ListArt { get; set; }
        public List<Articulos> busqueda;
        int var;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            var = Convert.ToInt32(Request.QueryString["var"]);

            try
            { ListArt = negocio.Listar();
                Session.Add("ListArt", ListArt);
                if (var == 0)
                {
                    busqueda = new List<Articulos>();
                    Session.Add("busqueda", busqueda);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (tbBuscar.Text == "")
                {
                    busqueda = negocio.Listar();
                    Session.Add("busqueda", busqueda);
                }
                else
                {   busqueda = ListArt.FindAll(i => i.Nombre.ToUpper().Contains(tbBuscar.Text.ToUpper()));
                    Session.Add("busqueda", busqueda);
                    Response.Redirect("Articulos.aspx?var=1");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}