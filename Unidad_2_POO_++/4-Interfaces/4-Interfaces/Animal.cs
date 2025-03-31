using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interfaces
{
    class Animal
    {


        public virtual string comunicarse()     // virtual -> me permite que los hijos puedan reescribir el metodo
        {
            return "ruido, ruido";
        }
    }
}
