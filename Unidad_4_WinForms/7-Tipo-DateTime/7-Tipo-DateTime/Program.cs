using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Tipo_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaTest = new DateTime(2004, 4, 1);
            Console.WriteLine("La fecha test es: " + fechaTest.ToString());

            DateTime fecha = DateTime.Now;

            /*
            fecha.Month -> te da el mes
            fecha.Day -> te da el dia
            fecha.Year -> te da el anio

                todas estas opciones te sirve para manipularlos por separado, para calcular la edad por medio de un metodo, etc
            */

            Console.WriteLine("La fecha y hora actual es: " + fecha.ToString());                   // dia y hora actual de la pc
            Console.WriteLine("La fecha si le agrego 5 dias es: " + fecha.AddDays(5));             // le agrego 5 dias al dia de hoy
            Console.WriteLine("La fecha sin hora es: " + fecha.ToShortDateString());               // me muestra solo fecha y NO la hora - version corta
            Console.WriteLine("La HORA sin FECHA es: " + fecha.ToShortTimeString());               // me muestra solo LA HORA y NO la FECHA - version corta

            // le podemos dar un formato puntual
            Console.WriteLine("La fecha con formato puntual del toString() es: " + fecha.ToString("dd/MM/yyyy"));               
            Console.WriteLine("La fecha con formato puntual del toString() es: " + fecha.ToString("dddd MM/yyyy"));               

            Console.ReadKey();
        }
    }
}
