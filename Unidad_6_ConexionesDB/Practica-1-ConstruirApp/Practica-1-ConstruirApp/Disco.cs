using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_ConstruirApp
{
    class Disco
    {
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Elemento Estilo { get; set; }
        public Elemento Edicion { get; set; }
    }
}
