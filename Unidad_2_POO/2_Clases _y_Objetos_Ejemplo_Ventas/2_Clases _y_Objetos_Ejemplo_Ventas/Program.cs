using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Clases__y_Objetos_Ejemplo_Ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Primer lote con 10 registros de productos, cada producto tiene:
             *      - Codigo articulo (3 digitos no correlativos)
             *      - Precio
             *      - Codigo de marca (1 a 10)
             *  Segundo lote con ventas de la semana. Cada venta tiene:
             *      - Codigo Articulo
             *      - Cantidad
             *      - Codigo Cliente (1 a 100)
             *  Este lote corta con codigo de cliente CERO.  
             */

            Articulo[] articulos = new Articulo[10];


            for (int i = 0; i < 10; i++)
            {
                // IMPORTANTE -> crear un objeto para cada vuelta del ciclo
                articulos[i] = new Articulo();

                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());


            }

            // a esta altura ya tenemos cargado el vector completo con los 10 articulos


            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo de Cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());


            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo Articulo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // trabajamos...

                // pido cliente nuevamente
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo de Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }


        }
    }
}
