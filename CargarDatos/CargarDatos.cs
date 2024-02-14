using Acceso_datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CargarDatos
{
    public class CargarDatosClass
	{ 
         
        public List<Articulo> cargarGrid()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos Datos = new AccesoDatos();
            try
			{
				Datos.setQuery("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.ImagenUrl, A.Precio from Articulos A, CATEGORIAS C, MARCAS M where A.Id = C.Id and  A.Id = M.Id");
				Datos.ejecutarLectura();

				while (Datos.Lector.Read())
				{
					Articulo articulo = new Articulo();
					articulo.Id = (int)Datos.Lector["Id"];
					articulo.Codigo = (string)Datos.Lector["Codigo"];
					articulo.Nombre = (string)Datos.Lector["Nombre"];
					articulo.Descripcion = (string)Datos.Lector["Descripcion"];
					articulo.CategoriaDesc = new Categoria();
					articulo.CategoriaDesc.CategoriaDescripcion = (string)Datos.Lector["Descripcion"];
					articulo.MarcaDesc = new Marca();
					articulo.MarcaDesc.MarcaDescripcion = (string)Datos.Lector["Descripcion"];
					articulo.ImagenUrl = (string)Datos.Lector["ImagenUrl"];
					articulo.Precio = (decimal)Datos.Lector["Precio"];

					listaArticulos.Add(articulo);
				}				

				return listaArticulos;
			}

			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				Datos.cerrarConexion();
			}
        }
    }
}
