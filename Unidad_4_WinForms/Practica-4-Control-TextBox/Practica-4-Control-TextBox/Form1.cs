using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_Control_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                // cambiar el color de fondo del TextBox si el TextBox se encuentra vació
                txtApellido.BackColor = Color.Red;
            }
            else
            {                
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)       // KeyPress ->  solo para ingresar Números
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNuevo.Text.Length + " Caracteres");
        }
    }
}
