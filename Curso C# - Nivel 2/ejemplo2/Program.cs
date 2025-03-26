using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicionales

            // IF
            // SWITCH

            /* OPERADORES RELACIONALES PARA EL IF
             *      == -> IGUALDAD
             *      != -> DISTINTO
             *      >  -> MAYOR
             *      <  -> MENOR
             *      >= -> MAYOR O IGUAL
             *      <= -> MENOR O IGUAL         
             */

            /* OPERADORES LOGICOS
             *      !  -> NEGADO
             *      && -> AND | Y
             *      || -> OR | O 
             * 
             */


            int a = 10, b = 12;

            if (a == b && b != 10 || (a==20))
            {
                // todo lo que necesite...

                Console.WriteLine("se cumple..");

                if (a != 9)
                {
                    // otra condicion
                }
            }
            else if (a == 15)
            {
                switch (a)
                {
                    case 1:
                        // instrucciones
                        break;
                    case 2:
                        // instrucciones
                        break;
                    default:
                        break;
                }
            }
            else if (b != a)
            {

            }
            else if (b < 10)
            {

            }
            else
            {
                // bloque opcional 
            }



        }
    }
}
