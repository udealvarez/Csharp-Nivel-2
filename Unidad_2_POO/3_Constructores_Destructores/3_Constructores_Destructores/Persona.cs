using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructores_Destructores
{
    class Persona
    {
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
