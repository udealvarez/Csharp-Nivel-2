using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_Control_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento click", "Atencion");

            // evento click -> cambia el color del formulario
            this.BackColor = Color.Blue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el boton IZQ", "ATENCION");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presiono el boton DER", "ATENCION");
            }

            if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presiono el boton del MEDIO", "ATENCION");
            }
        }
    }
}
