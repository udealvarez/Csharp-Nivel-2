using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Tipos_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();     // la clase persona NO PUEDE SER INSTANCIADA solo sus clases hijas
            Developer d1 = new Developer();
            Lider l1 = new Lider();         // no se puede instanciar la clase STATIC


            /*
             *  - TIPOS DE CLASES
             *       ABSTRAC -> abstract class Persona { } | no se puede crear instancias de la clase, estoy obligado a instanciar a los hijos | marca el inicio de una jerarquia
             *       SEALED  -> sealed class persona { }   | NO nos permite HEREDAR, si es que tenemos hijos | marca el final de una jerarquia  |  CLASE SELLADA
             *       STATIC  -> static class lider { }     | una clase STATICA no puede usar la herencia, no puede ser hija de otra clase (es una regla), ni padre de otra clase
             *                                             | no se puede crear una instancia de la clase
             *                                             | se puede usar, no hace falta crear una instancia para usar
             *                                             
             *               -> para que quiero una clase STATIC?
             *                      + para tener una clase HELPER
             *                      + una clase para tener validaciones de cosas
             *                      + una clase para cosas que uso seguido (mostrar en pantalla, pedir por pantalla)
             *                   
                     *                   Lider.validarTalCosa();
                     *                   Lider.validarLoOtro();
                     *                   
                     *                   Lider.mostrarEnPantalla();
                     *                   Lider.pedirPorPantalla();
             *                   
             *                      + de esta manera la clase va a estar disponible todo el tiempo, solo tengo que llamar y buscar el metodo
             *                      
             *                      + ES UNA CLASE QUE ESTA DISPONIBLE TODO EL TIEMPO
             *                      + NO NECESITAR SER INSTANCIADA
             *                      + LA PUEDO USAR CUANDO LA NECESITE
             *                      
             *                      + NOTA: NO abusar con clases staticas
             * 
             */

            Lider.algo();

            Tester n1 = new Tester();
            Tester.AlgoMAS();           // hay un gris aca - OJO


            Console.WriteLine("hola");  // CONSOLE ES UNA CLASE STATICA  |  si haces CONTROL + CLICK sobre CONSOLE te lleva a la definicion de la clase


        }
    }
}
