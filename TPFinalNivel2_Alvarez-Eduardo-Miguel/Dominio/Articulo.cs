using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Marcas")]
        public Elemento Marcas { get; set; }
        [DisplayName("Categoría")]
        public Elemento Categorias { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public int Categoria { get; set; }
        public int Marca { get; set; }


    }
}
