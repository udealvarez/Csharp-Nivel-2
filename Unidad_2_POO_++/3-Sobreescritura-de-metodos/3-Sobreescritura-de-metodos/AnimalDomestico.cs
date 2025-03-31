using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sobreescritura_de_metodos
{
    class AnimalDomestico:Animal
    {
        public string Nombre { get; set; }

        public override string ToString()       // override -> SOBRE ESCRIBIR
        {
            return "Animal Domestico: " + Nombre;
        }

    }
}
