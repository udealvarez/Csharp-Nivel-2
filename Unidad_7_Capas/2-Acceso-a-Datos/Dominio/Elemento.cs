using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()   // TENGO QUE REESCRIBIR PARA PODER VISUALIZARLO EN EL DATA GRID
        {
            return Descripcion;
        }
    }
}
