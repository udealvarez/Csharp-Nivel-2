﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interfaces
{
    class Aguila : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "vuela como un aguila...";
        }
    }
}
