using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Controles_basicos_eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)   // ESTO ES UN METODO DE CLASE DE FORM1
        {
            MessageBox.Show("HOLA MUNDO");

            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;


            /*
             *  ESTE METODO ES UN -> EVENTO
             *  
             *  un evento es un metodo asociado a un determinado contexto -> click del boton (cuando hacer click, se ejecuta el metodo)
             *  con el click se dispara el evento para que se ejecute
             * 
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("Te doy la bienvenida");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // evento se ejecuta cuando salis de la ventana
        {
            MessageBox.Show("Gracias por usar la app..");
        }
    }
}
