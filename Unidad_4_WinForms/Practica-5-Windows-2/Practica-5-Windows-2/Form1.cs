using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_Windows_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;


            if (nombre == "" || apellido == "" || edad == "" || direccion == "")
            {
                txtApellido.BackColor = Color.Red;
                txtNombre.BackColor = Color.Red;
                txtApellido.BackColor = Color.Red;
                txtEdad.BackColor = Color.Red;
                txtDireccion.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;


                string resultado = $"Apellido y nombre: {apellido} {nombre}\r\n" +
                               $"Edad: {edad}\r\n" +
                               $"Direccion: {direccion}\r\n";

                txtResultado.Text = resultado;
            }
                        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
