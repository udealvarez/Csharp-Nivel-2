using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre ="Ude";
            string apellido = "Alvarez";
            string segundoNombre = "miguel";

            // nombre = Console.ReadLine();    // ReadLine -> es un funcion que devuelve un string

            nombre = "hola como estas? soy " + nombre + " " + apellido;
            apellido = "hola como estas? soy " + nombre + " " + apellido;

            int cantidad = nombre.Length;

            nombre = nombre.ToUpper();            // ToUpper -> convierte todo a mayuscula
            segundoNombre = segundoNombre.ToLower();            // ToLower -> convierte todo a minuscula
            apellido = apellido.Replace('a', 'e');    // Replace -> de una palabra, REEMPLAZA la letra A por la letra E
            nombre = nombre.Replace("hola", "chau");

            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(cantidad);

            Console.ReadKey();


        }
    }
}
