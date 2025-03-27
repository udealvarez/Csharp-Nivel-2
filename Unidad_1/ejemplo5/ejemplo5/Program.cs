using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES..

            Console.WriteLine(saludar("ude"));      // llamo a la funcion y por argumento le paso un string
            Console.ReadKey();

            int b = 10;

            sumar(2, b);

           
        }

        static int sumar(int a, int z) // recibe parametros por valor
        {

            return a + z;
        }

        static string saludar(string nombre)        // recibe por parametros un string
        {
            return "hola " + nombre;
        }



    }
}
