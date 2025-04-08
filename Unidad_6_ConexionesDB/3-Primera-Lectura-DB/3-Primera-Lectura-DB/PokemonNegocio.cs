using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // DECLARAR LA LIBRERIA

namespace _3_Primera_Lectura_DB
{
    class PokemonNegocio
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
                command.CommandText = "SELECT Numero, Nombre, Descripcion FROM POKEMONS";
                command.Connection = connection;

                connection.Open();      // abro la coneccion
                lector = command.ExecuteReader();    // estoy haciendo una lectura

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

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
