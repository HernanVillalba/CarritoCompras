using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos> Listar()
        {
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;
            List<Articulos> lista = new List<Articulos>();
            Conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = "select a.id as IdArt, a.Codigo, a.nombre, a.descripcion, a.imagenurl, a.precio, c.id as IdCategoria, c.Descripcion as Categoria,m.id as IdMarca, m.Descripcion as Marca from ARTICULOS as a join CATEGORIAS c on a.IdCategoria = c.id join MARCAS as m on m.Id = a.IdMarca";
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Articulos Aux = new Articulos();
  
                    Aux.Id = (int)Lector["IdArt"];
                    Aux.Codigo = Lector.GetString(1);
                    Aux.Nombre = Lector.GetString(2);
                    Aux.Descripcion = Lector.GetString(3);
                    Aux.Imagen = (string)Lector["ImagenUrl"];
                    Aux.Precio = Lector.GetSqlMoney(5);

                    Aux.categoria = new Categoria();
                    Aux.categoria.Id = (int)Lector["IdCategoria"];
                    Aux.categoria.Descripcion = (string)Lector["Categoria"];

                    Aux.Marca = new Marca();
                    Aux.Marca.Descripcion = (string)Lector["marca"];
                    Aux.Marca.Id = (int)Lector["IdMarca"];


                    lista.Add(Aux);

                }
                Conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }       
        
        
        public void modificar(Articulos art)
        { AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery("Update Articulos set Codigo = @codArt, Nombre = @nombre, Descripcion = @descripcion, IdCategoria = @idCat, IdMarca = @idMar, ImagenUrl = @urlImagen, Precio = @precio  where Id = @id");
                conexion.agregarParametro("@codArt", art.Codigo);
                conexion.agregarParametro("@nombre", art.Nombre);
                conexion.agregarParametro("@descripcion", art.Descripcion);
                conexion.agregarParametro("@idCat", art.categoria.Id);
                conexion.agregarParametro("@idMar", art.Marca.Id);
                conexion.agregarParametro("@urlImagen", art.Imagen);
                conexion.agregarParametro("@precio", art.Precio);
                conexion.agregarParametro("@id", art.Id); 
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            { throw ex; }
            
        }

        public void agregar(Articulos nuevo)
        {
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            List<Articulos> lista = new List<Articulos>();

            Conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = "insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio ) values (@CodigoArt, @Nombre,@Descripcion,@ImagenUrl,@IdCategoria,@IdMarca, @precio)";

            Comando.Parameters.AddWithValue("@CodigoArt", nuevo.Codigo);
            Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
            Comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
            Comando.Parameters.AddWithValue("@ImagenUrl", nuevo.Imagen);
            Comando.Parameters.AddWithValue("@IdCategoria", nuevo.categoria.Id);
            Comando.Parameters.AddWithValue("@IdMarca", nuevo.Marca.Id);
            Comando.Parameters.AddWithValue("@precio", nuevo.Precio);
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.ExecuteNonQuery();

        }

 

        public void eliminar (int Id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery(" DELETE FROM ARTICULOS WHERE Id= @id");
                conexion.agregarParametro("@id", Id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }







}

   