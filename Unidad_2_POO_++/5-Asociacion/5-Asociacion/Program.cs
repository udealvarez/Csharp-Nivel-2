using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Asociacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASOCIACION: ES UN TIPO DE RELACION ENTRE CLASES

            /*
             * como se lee la ASOCIACION -> TIENE
             *      - un auto TIENE un motor 
             *      - un auto TIENE un chasis
             *      - una persona TIENE una direccion
             * 
             */

            
            Auto a1 = new Auto();       // creacion del objeto auto

            a1.Motor = new Motor();     // AGREGACION -> agrego el objeto motor al objeto auto | asociacion por agregacion


            Console.ReadKey();


        }
    }
}
