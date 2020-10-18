using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria>Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            List<Categoria> Lista = new List<Categoria>();

            //configuracion

            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select id, descripcion from CATEGORIAS";

            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Lista.Add(new Categoria((int)lector["Id"],(string)lector["Descripcion"]));
            }

            lector.Close();
            conexion.Close();
            return Lista;
        }
        

        
    }
}
