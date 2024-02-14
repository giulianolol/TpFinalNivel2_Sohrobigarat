using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    //Clase Marca con su Id y la descripcion
    public class Marca
    {
        public int Id { get; set; }
        public string MarcaDescripcion { get; set; }

        public override string ToString()
        {
            return MarcaDescripcion;
        }
    }
}
