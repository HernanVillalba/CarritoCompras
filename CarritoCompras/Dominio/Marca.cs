using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public string Descripcion { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

        public Marca(int id, string desc)
        {
            Id = id;
            Descripcion = desc;

        }

        public Marca() { }
    }
}
