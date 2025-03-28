using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Clases_Objetos_Propiedades_Encapsulamiento
{
    class Persona
    {
        // PERSONA: Edad, Nombre, Sueldo
        // ATRIBUTOS o MIEMBROS

        private int edad;
        private float sueldo;
        private string nombre;

        public void setEdad(int e)  // SETEAR
        {
            edad = e;
        }

        public int getEdad()        // GET -> OBTENER       |   el int es por que devuelve un entero
        {
            return edad;
        }

        


    }
}
