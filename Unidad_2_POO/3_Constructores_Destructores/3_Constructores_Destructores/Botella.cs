using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructores_Destructores
{
    class Botella
    {   
        // CONSTRUCTOR
        public Botella(string color, string material)   // -> esta linea se la denomina LA FIRMA DEL CONSTRUCTOR
        {
            this.color = color;
            this.material = material;
        }

        // SOBRECARGA EL CONSTRUCTOR
        public Botella(){}  // a esto tambien se lo llama SOBRECARGA DE METODOS o SOBRE CARGA DE CONSTRUCTOR

        // DESTRUCTOR
        ~Botella()
        {
            // la logica...
        }


        // PROPIEDADES PRIVADAS
        private int capacidad;
        private string color;
        private string material;
        public string Material
        {
            get { return material; }
        }


        // PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }       // GET -> OBTENER
            set { capacidad = value; }      // SET -> SETEAR
        }

        /*
         * El Garbage Collector (GC) 
         * administra de forma automática la memoria, 
         * ya que es el encargado de liberar los objetos que ya no están en uso y que no serán usados en el futuro.
         */

    }
}
