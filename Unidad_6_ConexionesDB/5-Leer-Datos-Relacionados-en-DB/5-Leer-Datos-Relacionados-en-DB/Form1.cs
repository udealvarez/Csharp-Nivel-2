using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Leer_Datos_Relacionados_en_DB
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;       // con esta linea oculto la columna de URL IMAGEN

            pbPokemon.Load(listaPokemon[0].UrlImagen);

        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            // CurrentRow -> fila actual
            Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;       // de la grilla, de la fila actual, dame el objeto enlazado                        
            cargarImagen(pokemonSeleccionado.UrlImagen);
        }

        public void cargarImagen(string imagen)
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
    }
}
