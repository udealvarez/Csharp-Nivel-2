using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Telefono
    {
        // PROPIEDADES
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        private int codigoOperador;
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value == 1 || value == 2 || value == 3)     // validamos que una de estas opciones sean ciertas
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;     // si no es valido le asignamos 0
                }
            }
        }

        // CONSTRUCTOR
        public Telefono(string modelo, string marca)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        // METODOS
        public string llamar()
        {
            return "Realizando llamada...";
        }

        // METODO SOBRECARGADO
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
