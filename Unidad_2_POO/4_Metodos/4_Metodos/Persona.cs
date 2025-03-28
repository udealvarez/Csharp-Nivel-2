using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Metodos
{
    class Persona
    {
        // PERSONA: Edad, Nombre, Sueldo
        // ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        // CONSTRUCTOR
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)  
        {
            edad = e;
        }

        public int getEdad()       
        {
            return edad;
        }

        // METODOS
        public string saludar()
        {
            return "Hola soy " + nombre;
        }





    }
}
