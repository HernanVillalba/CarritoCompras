using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            List<Marca> Lista = new List<Marca>();

            //configuracion

            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select id, descripcion from MARCAS";

            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Lista.Add(new Marca((int)lector["Id"], (string)lector["Descripcion"]));
            }

            lector.Close();
            conexion.Close();
            return Lista;
        }
    }
}
