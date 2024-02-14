using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    //Clase Categoria con su Id y la descripcion
    public class Categoria
    {
        public int Id { get; set; }
        public string CategoriaDescripcion { get; set; }

        public override string ToString()
        {
            return CategoriaDescripcion;
        }
    }
}
