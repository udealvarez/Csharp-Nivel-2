using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Detalle : Form
    {
        private Articulo Articulo = null;
        public Detalle(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = "Detalle de Articulo";
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (Articulo != null)
                {
                    lblCodigo2.Text = Articulo.CodArticulo;
                    lblNombre2.Text = Articulo.Nombre;
                    lblPrecio2.Text = Articulo.Precio.ToString();
                    cargarImagen(Articulo.ImagenUrl);
                    lblCodigoMarca2.Text = Articulo.Marca.ToString();
                    lblMarca2.Text = Articulo.Marcas.Descripcion;
                    lblCodigoCategoria2.Text = Articulo.Categoria.ToString();
                    lblCategoria2.Text = (Articulo.Categorias.Descripcion);
                    lblDescripcion2.Text = Articulo.Descripcion;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
