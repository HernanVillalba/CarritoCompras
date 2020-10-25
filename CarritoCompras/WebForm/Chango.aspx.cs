using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Chango : System.Web.UI.Page
    {
        protected Carrito carro = new Carrito();
        public List<Articulos> ListaCarrito = new List<Articulos>();
        protected List<Articulos> ListaAux;
        protected int IDAux;
        protected int agregar;
        protected int eliminar;
        protected int vaciar;
        protected Articulos articuloBuscado = new Articulos();
        protected ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            ExisteListaAgregados();
            //--------------- SESSION = ListaArtAgregados----------------------------
            eliminar = Convert.ToInt32(Request.QueryString["delete"]);
            IDAux = Convert.ToInt32(Request.QueryString["IDsrc"]);
            agregar = Convert.ToInt32(Request.QueryString["agregar"]);
            vaciar = Convert.ToInt32(Request.QueryString["empty"]);
            articuloBuscado = (negocio.Listar()).Find(i => i.Id == IDAux);

            if (IDAux != 0 && agregar == 1)
            {
                AgregarItemLista();
                //para Re-direccionar luego de cargar un articulo
                Response.Redirect("Articulos.aspx");
            }
            else if (IDAux != 0 && eliminar == 1)
            {
                EliminarItem();
                //para Re-cargar el carro después de eliminar
                Response.Redirect("Chango.aspx");
            }
            else if(vaciar == 1)
            {
                VaciarCarrito();
                Response.Redirect("Chango.aspx");
            }


            CargarEtiquetasPrecioYCantidad();
        }

        protected void VaciarCarrito()
        {
            ListaAux = new List<Articulos>();
            ListaCarrito = ListaAux;
            Session["ListaArtAgregados"] = ListaCarrito;
        }
        protected void CargarEtiquetasPrecioYCantidad()
        {
            //para cargar precio y cantidad
            foreach (Articulos item in ListaCarrito)
            {
                carro.Cantidad++;
                carro.Total += item.Precio;
            }

            //cargo las etiquetas para mostrar
            lblCantidad.Text = carro.Cantidad.ToString();
            lblTotal.Text = carro.Total.ToString();
        }
        protected void EliminarItem()
        {
            foreach (Articulos item in ListaCarrito)
            {
                if (item.Id == IDAux)
                {
                    ListaCarrito.Remove(item);
                    Session["ListaArtAgregados"] = ListaCarrito;
                    Response.Redirect("Chango.aspx");
                }
            }
        }
        protected void ExisteListaAgregados()
        {
            if (Session["ListaArtAgregados"] == null)
            {
                Session["ListaArtAgregados"] = new List<Articulos>();
            }
            else
            {
                ListaCarrito = (List<Articulos>)Session["ListaArtAgregados"];
            }
        }
        protected void AgregarItemLista()
        {
            try
            {
                if (Session["ListaArtAgregados"] == null) //si no existe, lo agrega como primero
                {
                    ListaCarrito.Add(articuloBuscado);
                    Session["ListaArtAgregados"] = ListaCarrito;
                }
                else
                {
                    //
                    ((List<Articulos>)Session["ListaArtAgregados"]).Add(articuloBuscado);
                    ListaCarrito = ((List<Articulos>)Session["ListaArtAgregados"]);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}