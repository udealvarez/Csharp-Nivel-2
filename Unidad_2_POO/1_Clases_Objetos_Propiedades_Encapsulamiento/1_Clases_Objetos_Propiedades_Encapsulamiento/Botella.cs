using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Clases_Objetos_Propiedades_Encapsulamiento
{
    class Botella
    {
        // Botella: Capacidad, Color, Material

        private int capacidad;
        private string color;
        private string material;


        // PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }       // GET -> OBTENER
            set { capacidad = value; }      // SET -> SETEAR
        }


    }
}
