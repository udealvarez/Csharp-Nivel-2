using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sobreescritura_de_metodos
{
    class Animal
    {



        public virtual string comunicarse()     // virtual -> me permite que los hijos puedan reescribir el metodo
        {
            return "ruido, ruido";
        }




    }
}
