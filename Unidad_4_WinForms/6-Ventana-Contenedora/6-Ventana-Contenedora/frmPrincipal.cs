using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Ventana_Contenedora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (var item in Application.OpenForms) // OpenForms -> es una coleccion de OBJETOS VENTANA 
            {
                if (item.GetType() == typeof(Form1))    
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar alli");
                    return;     // return -> puedo usarlo para terminar la ejecucion
                }

                /*  if (item.GetType() == typeof(Form1)) 
                 *  
                 *  del form que estoy en esta vuewlta actual (ITEM), el GETTYPE te devuelve el tipo de objeto que es
                 *   (IF) si el tipo de objeto ese, es IGUAL a el tipo de objeto que yo estoy buscando (objeto FORM1)
                 *  si el TYPEOF(FORM1)
                 *  
                 *  EN CASTELLANO
                 *  
                 *      si dentro de la coleccion en alguna de las vueltas encuentra un formulario que sea del mismo
                 *      tipo que yo estoy queriendo abrir a continuacion, lo uqe va hacer esto es un RETURN( HASTA ACA LLEGA LA EJECUCION)
                 *      y lo que esta lineas mas abajo, NO LO VA HACER
                 */
            }


            Form1 formulario = new Form1();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void tsbPerfilPersonal_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
