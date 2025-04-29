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


namespace WinForms_App
{
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;

        public FrmAltaPokemon()
        {
            InitializeComponent();
        }

        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";     // modifica el nombre del formulario en el formulario de modificar

            /*
             *      this.pokemon = linea 18
             *      pokemon de linea 28 hace referencia al pokemon del parametro             * 
             */
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

        private void txtUrlImagen_Leave(object sender, EventArgs e)// propiedad del textbox URL IMAGEN -> LEAVE
        {
            cargarImagen(txtUrlImagen.Text);
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
        }

        /*
        * picture box 
        *      ziseMode -> strechtimage (ajusta la imagen al picture box)
        */
    }
}
