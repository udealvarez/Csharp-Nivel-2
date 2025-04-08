using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_1_ConstruirApp
{
    class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;

            try
            {
               // connection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DISCOS_DB;Integrated Security=True";

                connection.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT D.Titulo, D.CantidadCanciones as Cantidad_Canciones, D.UrlImagenTapa, e.Descripcion as Estilo, t.Descripcion as Edicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE e.Id = d.IdEstilo AND t.Id = D.IdTipoEdicion";
                command.Connection = connection;

                connection.Open();

                lector = command.ExecuteReader();       // HAGO LA LECTURA

                while (lector.Read())
                {
                    Disco auxiliar = new Disco();

                    auxiliar.Titulo = (string)lector["Titulo"];
                    auxiliar.CantidadCanciones = (int)lector["Cantidad_Canciones"];     // MEJOR VERSION
                    auxiliar.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    auxiliar.Estilo = new Elemento();
                    auxiliar.Edicion = new Elemento();

                    auxiliar.Estilo.Descripcion = (string)lector["Estilo"];
                    auxiliar.Edicion.Descripcion = (string)lector["Edicion"];

                    lista.Add(auxiliar);
                }

                connection.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
