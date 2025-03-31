using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interfaces
{
    class Gato : AnimalDomestico
    {


        public override string comunicarse()        // sobre escritura de metodo -> del padre a hijo
        {
            return "miau, miau";
        }

    }
}
