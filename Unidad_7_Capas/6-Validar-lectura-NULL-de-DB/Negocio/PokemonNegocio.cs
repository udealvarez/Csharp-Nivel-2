using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // DECLARAR LA LIBRERIA
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
    {

        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true;";
                command.CommandType = System.Data.CommandType.Text;
                //command.CommandText = "SELECT Numero, Nombre, Descripcion, UrlImagen FROM POKEMONS";
                // command.CommandText = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as Tipo FROM POKEMONS p, ELEMENTOS e WHERE e.Id = p.IdTipo";

                // esta consulta trae la DEBILIDAD TAMBIEN
                command.CommandText = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as Tipo, d.Descripcion as Debilidad FROM POKEMONS p, ELEMENTOS e, ELEMENTOS d WHERE e.Id = p.IdTipo AND d.Id =p.IdDebilidad";
                command.Connection = connection;

                connection.Open();      // abro la coneccion
                lector = command.ExecuteReader();    // estoy haciendo una lectura

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen")))) // con esto tengo en cuenta si tengo NO tengo un null en la base que lo haga
                    //{                                                           // es para que no pinche
                    //    aux.UrlImagen = (string)lector["UrlImagen"];
                    //}

                    if (!(lector["UrlImagen"] is DBNull))   // esto es mas practico
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    }

                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    /*
                     *   "Tipo" es un objeto que esta compuesto en el pokemon, pero que cuando nace la clase pokemon, no tiene instancia.
                     *   si voy hacer aux.Tipo.Descripcion = (string)lector["Tipo"]; mi properti TIPO no va a tener una instancia,
                     *   lo que tengo que hacer es la linea..39
                     */

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

        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad) values (" + nuevo.Numero + ",'" + nuevo.Nombre + "','" + nuevo.Descripcion + "',1, @idTipo, @idDebilidad)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Pokemon modificar)
        {

        }

    }
}
