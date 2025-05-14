using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion as Tipo, IdMarca, IdCategoria, ImagenUrl, Precio, C.Descripcion as Categorias, M.Descripcion as Marcas from ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                command.Connection = connection;

                connection.Open();
                lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Tipo"];
                    aux.Marca = (int)lector["IdMarca"];
                    aux.Categoria = (int)lector["IdCategoria"];

                    if (!(lector["ImagenUrl"] is DBNull))   
                    {
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    }

                    aux.Precio = (decimal)lector["Precio"];
                    
                    aux.Categorias = new Elemento();
                    aux.Categorias.Descripcion = (string)lector["Categorias"];

                    aux.Marcas = new Elemento();
                    aux.Marcas.Descripcion = (string)lector["Marcas"];

                    lista.Add(aux);
                }

                connection.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
