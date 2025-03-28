using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Sobrecarga_de_Metodo
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

        // SOBRECARGA DE METODOS
        // para la sobrecarga de metodos tiene un minimo cambio en la firma pero tiene que devolver lo mismo que el metodo original y no puede cambiar de nombre
        // lo que puede cambiar son los parametros que recibe 

        public string saludar(string personaje)     // sobrecarga recibe parametro/s
        {                           
            return "Hola " + personaje + ", soy " + this.nombre;       // this.nombre -> este es MI nombre 
        }








    }
}
