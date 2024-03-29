﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        //Clase Articulo con sus propiedades
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public int IdMarca { get; set; } Extraer de otra tabla
        public Marca MarcaDesc { get;  set; }
        //public int IdCategoria { get; set; } Extraer de otra tabla
        public Categoria CategoriaDesc { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
    }
}
