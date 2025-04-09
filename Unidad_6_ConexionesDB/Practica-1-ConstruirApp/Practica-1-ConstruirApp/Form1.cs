using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_ConstruirApp
{
    public partial class Form1 : Form
    {

        private List<Disco> listaDiscos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDiscos = negocio.listar();

            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;

            pbDiscos.Load(listaDiscos[0].UrlImagenTapa);
            
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco discoSeleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(discoSeleccionado.UrlImagenTapa);
        }

        private void cargarImagen(string ImagenTapa)
        {
            try
            {
                pbDiscos.Load(ImagenTapa);
            }
            catch (Exception ex)
            {

                pbDiscos.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
