using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        //viendo el tutorial de masssiPrograma para usar gitBash
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public SqlMoney Precio { get; set; }

        public Categoria categoria { get; set; }

        public Marca Marca { get; set; }



    }



}
