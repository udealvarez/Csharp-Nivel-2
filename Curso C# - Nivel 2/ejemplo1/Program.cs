using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            // tipo de datos elementales -> int - float - bool - char
            // otros tipos de datos -> double - decimal - long - short - string - datetime

            int a, b, c;
            float d, f;

            Console.WriteLine("Hola Como va?");
            Console.WriteLine("Ingrese un numero: ");
            
            a = int.Parse(Console.ReadLine());
            b = 10;
            c = a + b;

            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
