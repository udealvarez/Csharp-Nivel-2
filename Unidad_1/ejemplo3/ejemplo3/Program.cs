using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ciclos -> for - while - do while

            /* OPERADORES
             *      ++ -> INCREMENTO
             *      -- -> DECRECIMIENTO
             *      += -> ACUMULADOR
             *      -+ -> DISMINUCION
             *      *= -> hace lo mismo que el acumulador
             *      /+ -> hace lo mismo que el acumulador
             */

            int a = 10;

            for (int i = 0; i < 10; i++)
            {
                while (a != 0)
                {
                    Console.WriteLine("Hola " + a);
                    a--;
                }                
            }
            Console.ReadKey();


            do
            {
                // codigo
                // codigo
                // codigo

            } while (a != 0);
        }
    }
}
