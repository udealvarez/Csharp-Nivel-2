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
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();

            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;

            pbPokemon.Load(listaPokemon[0].UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();

            // actulizar la carga del nuevo pokemon
            cargar();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;       // de la grilla, de la fila actual, dame el objeto enlazado                        
            cargarImagen(pokemonSeleccionado.UrlImagen);

            /*
             *  PROPIEDADES DE DATAGRID
             *  
             *  SELECCIONAR UNA SOLA FILA
             *  prop del data grid
             *      selection mode -> fullrowselect
             *      
             *  EVITAR EDITAR CELDA INDIVIDUAL
             *  prop del data grid
             *      editmode -> editprogrammatically
             *      
             *  EVITAR SELECCION MULTIPLE DE FILAS
             *  prop del data grid
             *      multiselect -> false
             */



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
    }
}
