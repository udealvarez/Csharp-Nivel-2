using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace WinFormsApp
{
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;

        public FrmAltaPokemon()
        {
            InitializeComponent();
        }

        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";     // modifica el nombre del formulario en el formulario de modificar
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if (pokemon == null) // quiere decir que toque AGREGAR y NO modificar
                {
                    pokemon = new Pokemon();
                }

                pokemon.Numero = Convert.ToInt32(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cbTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbDebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente", "ATENCION");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente", "ATENCION");
                }

                // guardo imagen si la levanto localmente
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cbTipo.DataSource = elementoNegocio.listar();
                // estas 2 lineas te permite que cuando quieras modificar tomes el id y la descripcion
                cbTipo.ValueMember = "Id";
                cbTipo.DisplayMember = "Descripcion";

                cbDebilidad.DataSource = elementoNegocio.listar();
                cbDebilidad.ValueMember = "Id";
                cbDebilidad.DisplayMember = "Descripcion";

                // pre cargar los datos en las cajas de texto
                if (pokemon != null)// si es distinto de nulo -> tengo un pokemon para MODIFICAR
                {
                    txtNumero.Text = pokemon.Numero.ToString(); // ToString() -> por que es un numero
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;

                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);

                    cbTipo.SelectedValue = pokemon.Tipo.Id; // SelectedValue -> el valor seleccionado por el ID (linea 46)
                    cbDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pbPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }

            // URL DEL POKEMON ELIMINADO    - >    https://assets.pokemon.com/assets/cms2/img/pokedex/full/016.png

            /*
            *   picture box 
            *      ziseMode -> strechtimage (ajusta la imagen al picture box)
            */
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog(); // esto es para levantar una imagen
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)    // cuando esto abra, si el resultado es OK (elijo la foto y aceptar), entra 
            {                                               // esto te permite capturar un archivo
                txtUrlImagen.Text = archivo.FileName;   // esto me guarda la ruta completa del archivo que estoy seleccionando
                cargarImagen(archivo.FileName); // esto me devuelve la ruta completa y el nombre del archivo   


                // guardo la imagen
    //            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                // la clase FILE es ESTATICA y la puedo usar con un par de metodos
                // images-folder -> app config      |  SafeFileName -> nombre original del archivo
            }
        }
    }
}
