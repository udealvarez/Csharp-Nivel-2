﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sobreescritura_de_metodos
{
    class Perro : AnimalDomestico
    {


        public override string comunicarse()
        {
            return "guau, guau";
        }

    }
}
