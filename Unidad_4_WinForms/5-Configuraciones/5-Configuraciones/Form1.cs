using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Configuraciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;             // nos devuelve un string
            DateTime fecha = dtpFechaNacimiento.Value;  // .value -> NOS DEVUELVE UN DATETIME

            // OPERADOR TERNARIO
            string chocolate = cbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            // RADIO BUTTON
            string tipo;

            if (rbMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else if (rbWizard.Checked)
            {
                tipo = "Wizard";
            }
            else
            {
                tipo = "Squibs";
            }


            // COMBO BOX
            string colorFavorito = cboColorFav.SelectedItem.ToString();

            // NUMERIC UP DOWN
            string numeroFavorito = nudNumeroFav.Value.ToString();


            // MOSTRAR EL OBJETO PERSONA EN UN MENSAJE
            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + ", Fecha: " + fecha + ", " + mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // CARGO EL COMBO BOX
            cboColorFav.Items.Add("Azul");
            cboColorFav.Items.Add("Verde");
            cboColorFav.Items.Add("Rojo");
            cboColorFav.Items.Add("Negro");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;

            lvElementos.Items.Add(elemento);    // cada vez que aprete click voy agregar un nuevo elemento
        }
    }
}
