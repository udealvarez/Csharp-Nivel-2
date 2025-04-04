using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sobreescritura_de_metodos
{
    class Gato:AnimalDomestico
    {



        /*
         * si quiero reescribir un metodo padre en el hijo, primero en el metodo del padre tiene que ser VIRTUAL.
         * luego cuando escribimos public override (ESPACIO) tiene que aparecer el metodo del padre, en este caso COMUNICARSE()
         * le doy TAB y me arma la estructura como el tostring()
         */

        public override string comunicarse()        // sobre escritura de metodo -> del padre a hijo
        {
            return "miau, miau";
        }


    }
}
