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
            dgvPokemons.Columns["Id"].Visible = false;

            pbPokemon.Load(listaPokemon[0].UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();   
            alta.ShowDialog();

            cargar();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;       // de la grilla, de la fila actual, dame el objeto enlazado                        
            cargarImagen(pokemonSeleccionado.UrlImagen);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // aca selecciono el objeto pokemon de la grilla
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            FrmAltaPokemon modificar = new FrmAltaPokemon(seleccionado);// por parametro le tengo que pasar el objeto pokemon que quiero modificar
            modificar.ShowDialog();                             // LLAMO AL CONSTRUCTOR DEL FRM QUE TIENE COMO OBJETO UN POKEMON

            // actulizar la carga del nuevo pokemon
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon selecionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selecionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                    negocio.eliminar(selecionado.Id);

                    cargar(); // actualizo la grilla y desaparece el eliminado
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
