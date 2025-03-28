using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Sobrecarga_de_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona personaUno = new Persona("Ude");
            personaUno.setEdad(20);


            Console.WriteLine(personaUno.saludar());
            Console.WriteLine(personaUno.saludar("maxi"));
            Console.WriteLine("La edad de la persona es: " + personaUno.getEdad()); // GET -> OBTENGO LA EDAD


            // Botella
            Console.WriteLine("Ejemplo de la botella con metodos");

            Botella botellaUno = new Botella("Rojo", "Plastico");

            Console.WriteLine("CAPACIDAD BOTELLA " + botellaUno.Capacidad);
            Console.WriteLine("CAPACIDAD ACTUAL ES " + botellaUno.CantidadActual);

            botellaUno.recargar(20);
            Console.WriteLine("LUEGO DE RECARGAR, LA CAPACIDAD ACTUAL ES " + botellaUno.CantidadActual);
            botellaUno.recargar();
            Console.WriteLine("LUEGO DE RECARGAR, LA CAPACIDAD ACTUAL ES " + botellaUno.CantidadActual);



            Console.ReadKey();




        }
    }
}
