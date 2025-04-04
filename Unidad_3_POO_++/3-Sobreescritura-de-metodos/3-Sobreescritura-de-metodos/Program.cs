using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sobreescritura_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //    AnimalDomestico a1 = new AnimalDomestico();
            //   a1.Nombre = "Junior";

            Gato g1 = new Gato();
            g1.Nombre = "pepe";

            Perro p1 = new Perro();
            p1.Nombre = "John";
            

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());


            foreach (Animal animals in animales)
            {
                Console.WriteLine(animals.comunicarse());
            }

            // POLIMORFISMO: es la caracteristica que tienen los objetos de frente a un mismo estimulo comportarse de manera de distinta
                                                                      // de frente a un mismo METODO....
                                                                      // metodo -> comunicarse()

            
            Console.WriteLine(g1.comunicarse());
            Console.WriteLine("El perro se comunica... " + p1.comunicarse());

            Console.ReadKey();


        }
    }
}
