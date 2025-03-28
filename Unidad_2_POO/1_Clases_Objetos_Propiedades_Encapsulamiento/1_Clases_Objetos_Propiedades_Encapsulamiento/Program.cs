using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Clases_Objetos_Propiedades_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona();

            personaUno.setEdad(20);


            // ENCAPSULAMIENTO: define que los atributos de una clase tienen que estar ocultos al exterior

            Console.WriteLine("La edad de la persona es: " + personaUno.getEdad()); // GET -> OBTENGO LA EDAD


            Botella botellaUno = new Botella();
            botellaUno.Capacidad = 200;         // aca le asigno a la propiedad capacidad 200

            int algo = botellaUno.Capacidad;    // le puedo asignar lo que tenga la capacidad de la botella 1 en la variable ALGO


            // EJERCICIO PERRO
            Perro perroUno = new Perro();
            perroUno.nombre = "Junior";
            perroUno.color = "Negro";
            perroUno.origen = "Tortuguitas";

            Console.WriteLine("El perro se llama " + perroUno.nombre + ", su color es " + perroUno.color + " y es de " + perroUno.origen);           

            Console.ReadKey();                        

        }
    }
}
