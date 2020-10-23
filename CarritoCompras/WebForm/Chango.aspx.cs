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
        protected Articulos articuloBuscado = new Articulos();
        protected ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            ExisteListaAgregados();
            //--------------- SESSION = ListaArtAgregados----------------------------
            eliminar = Convert.ToInt32(Request.QueryString["delete"]);
            IDAux = Convert.ToInt32(Request.QueryString["IDsrc"]);
            agregar = Convert.ToInt32(Request.QueryString["agregar"]);
            articuloBuscado = (negocio.Listar()).Find(i => i.Id == IDAux);
            if (agregar == 1)
            {
                AgregarItemLista();
            }
            if(eliminar == 1)
            {
                Session["ListaArtAgregados"] = ListaAux = new List<Articulos>();
                ListaCarrito = ListaAux = new List<Articulos>();
            }

            //para mostrar precio y cantidad
            foreach (Articulos item in ListaCarrito)
            {
                carro.Cantidad++;
                carro.Total += item.Precio;
            }

            //cargo las etiquetas
            lblCantidad.Text = carro.Cantidad.ToString();
            lblTotal.Text = carro.Total.ToString();
        }
        protected void ExisteListaAgregados()
        {
            if (Session["ListaArtAgregados"] == null)
            {
                Session["ListaArtAgregados"] = new List<Articulos>();
            }
        }
        protected void AgregarItemLista()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                /*
                articuloBuscado = (negocio.Listar()).Find(i => i.Id == IDAux);
                ((List<Articulos>)Session["ListaArtAgregados"]).Add(articuloBuscado);
                ListaCarrito = ((List<Articulos>)Session["ListaArtAgregados"]);
                */
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