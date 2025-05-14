using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Categoria
    {
        public List<Elemento> lista()
        {
            List<Elemento> listaCategoria = new List<Elemento>();
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Elemento aux = new Elemento();

                    aux.Id = (int)acceso.Lector["Id"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];

                    listaCategoria.Add(aux);
                }

                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }
    }
}
