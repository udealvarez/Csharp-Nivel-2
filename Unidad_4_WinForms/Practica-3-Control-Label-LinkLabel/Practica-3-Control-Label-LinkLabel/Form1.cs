using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3_Control_Label_LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            // Cambiamos el color de la propiedad BackColor.
            lblEtiqueta.BackColor = Color.Cyan;

            // Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta.
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            // Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta.
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;

            // Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta.
            lblEtiqueta.Cursor = Cursors.Arrow;
        }
    }
}
