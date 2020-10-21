using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public SqlMoney Total { get; set; }
        public int Cantidad { get; set; }


        public Carrito()
        {
            Total = 0;
            Cantidad = 0;
        }
    }
}
