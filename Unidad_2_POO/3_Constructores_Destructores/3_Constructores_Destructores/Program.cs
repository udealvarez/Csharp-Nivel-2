using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructores_Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona();
            personaUno.setEdad(20);

            // ENCAPSULAMIENTO: define que los atributos de una clase tienen que estar ocultos al exterior

            Console.WriteLine("La edad de la persona es: " + personaUno.getEdad()); // GET -> OBTENGO LA EDAD


            Botella botellaUno = new Botella("Rojo","Plastico"); // new (palabra reservada) para invocar al constructor de la clase
            botellaUno.Capacidad = 200;

            Botella botellaDos = new Botella();




            Console.ReadKey();

        }
    }
}
