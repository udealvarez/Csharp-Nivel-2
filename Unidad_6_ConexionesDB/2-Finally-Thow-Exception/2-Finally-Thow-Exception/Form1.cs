using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Finally_Thow_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            
            try          // intenta ejecutar el siguiente bloque
            {
                resultado = calcular(); // esto devuelve una EX y tiene que ser auditado por un TRY

                lblResultado.Text = "=  " + resultado;   
            }            
            catch (Exception ex)
            {    
                MessageBox.Show("Error no reconocido...", "ATENCION");
            }
            finally     // SE EJECUTA SIEMPRE
            {
                // INSTRUCCIONES QUE SI O SI NECESITO QUE SE EJECUTEN

                // OPERACION SENSIBLE
            }
        }


        private int calcular() // este metodo devuelve un resultado
        {
            int a, b, resul;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);

                resul = a / b;

                return resul;
            }
            catch (Exception ex)
            {
                // guardar un registro de error en archivo
                throw ex;  // LANZA... DEVOLVER LA EXCEPCION
            }
        }
    }
}
