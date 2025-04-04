using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // VEHICULOS > AUTO > AUTO DEPORTIVO > AUTO URBANO
            // CAMIONETA
            // MOTO

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            Camioneta c4 = new Camioneta();

            c1.Color = "amarillo";
            c2.Color = "roja";
            c3.Color = "blanca";
            c4.Color = "negro";


            List<Camioneta> listaCamionetas = new List<Camioneta>();

            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);
            listaCamionetas.Add(c4);


            Console.WriteLine("la cantidad de camionetas es: " + listaCamionetas.Count);    // Count -> aca nos da la cantidad de elementos de la lista
            Console.WriteLine("El color es: " + listaCamionetas[1].Color);      // listaCamionetas[1].Color -> me da el color del elemento 1 de los elementos --> ROJA
            listaCamionetas.Remove(c3);
            Console.WriteLine("la cantidad de camionetas es: " + listaCamionetas.Count);    // Count -> aca nos da la cantidad de elementos de la lista despues de eliminar uno


            // quiero ver el color de todas las camionetas
            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            Console.ReadKey();

        }
    }
}
