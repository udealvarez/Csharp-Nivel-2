using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Tipo_DateTime_Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            
            DateTime fecha1;

            fecha1 = dtpFecha.Value;

            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dd/MM/yyyy")); 

        }

        private void btnPrueba1B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToString("dd/MM/yyyy")); // le doy el formato que quiero en el toString
            MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value); // Value -> me devuelve un tipo de dato DATETIME
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart);
            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("dd/MM/yyyy"));

            /* 
             * con el CALENDARIO tenes muchas funciones, ya que le pones un nombre, (calFecha) y si despues ponemos . (PUNTO) podemos
             * acceder a esas funciones como por ejemplo SelectionStart que indica donde comienza, hay otros mas
             */

        }
    }
}
