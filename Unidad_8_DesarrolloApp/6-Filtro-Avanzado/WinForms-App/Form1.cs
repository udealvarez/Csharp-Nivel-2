using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbCampo.Items.Add("Numero");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Descripcion");
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();

            dgvPokemons.DataSource = listaPokemon;
            ocultarColumnas();
            pbPokemon.Load(listaPokemon[0].UrlImagen);
        }

        private void ocultarColumnas()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();

            cargar();
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
            eliminar();
        }

        private void btnEliminacionLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false) // al mandar esto es un valor opcional -> SINO le mando un valor por parametro lo va a tomar falso por defecto
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon selecionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selecionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        negocio.eliminarLogico(selecionado.Id);
                    }
                    else
                    {
                        negocio.eliminar(selecionado.Id);
                    }

                    cargar(); // actualizo la grilla y desaparece el eliminado
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
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
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;       // de la grilla, de la fila actual, dame el objeto enlazado                        
                cargarImagen(pokemonSeleccionado.UrlImagen);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3) // ME FILTRA CON MAS DE 3 CARACTERES
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper())); // (lo que esta aca) -> funcion landa
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TXT FILTRO --->  CLICK DERECHO -> PROPEDADES -> RAYO -> KEYPRESS

            //List<Pokemon> listaFiltrada;
            //string filtro = txtFiltro.Text;

            //if (filtro != "")
            //{
            //    listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper())); // (lo que esta aca) -> funcion landa
            //}
            //else
            //{
            //    listaFiltrada = listaPokemon;
            //}

            //dgvPokemons.DataSource = null;
            //dgvPokemons.DataSource = listaFiltrada;
            //ocultarColumnas();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();    // esto lo que va hacer es guardame el elemento seleccionado, que puede ser cualquiera, nombre, numero o texto 

            if (opcion == "Numero")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }
    }
}
