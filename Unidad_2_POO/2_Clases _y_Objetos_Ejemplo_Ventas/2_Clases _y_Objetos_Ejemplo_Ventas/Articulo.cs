using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Clases__y_Objetos_Ejemplo_Ventas
{
    class Articulo
    {
        // codigo articulo, precio, codigo de la marca

//        private int codArticulo;
  //      private float precio;
        private int codMarca;

        public int CodigoArticulo { get; set; } // PROPIEDAD SOLO LECTURA SI DEJO SOLO -> { get; } 
        public float Precio { get; set; }

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                {
                    codMarca = value;
                }
                else
                {
                    codMarca = -1;
                }
            }
        }

    }
}
