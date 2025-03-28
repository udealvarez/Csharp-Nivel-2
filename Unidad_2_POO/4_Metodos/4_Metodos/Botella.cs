using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Metodos
{
    class Botella
    {
        // CONSTRUCTOR

        /* capacidad maxima: 100
         * cantidadActual: inicia en 0
         * metodo recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100
         */

        public Botella(string color, string material)   // -> esta linea se la denomina LA FIRMA DEL CONSTRUCTOR
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        // SOBRECARGA EL CONSTRUCTOR
        public Botella() { }  // a esto tambien se lo llama SOBRECARGA DE METODOS o SOBRE CARGA DE CONSTRUCTOR

        // DESTRUCTOR
        ~Botella()
        {
            // la logica...
        }


        // PROPIEDADES PRIVADAS
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        public int Capacidad
        {
            get { return capacidad; }        // propiedad solo lectura
        }
        public int CantidadActual
        {
            get { return cantidadActual; }        // propiedad solo lectura
        }
        public string Material
        {
            get { return material; }        // propiedad solo lectura
        }

        // METODO RECARGA
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int diferencia = capacidad - cantidadActual;
                // 100 vale 50
                // diferencia vale X -> REGLA DE 3
                float monto = (diferencia * 50) / 100;
                cantidadActual += diferencia;

                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

    }
}
