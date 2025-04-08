using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, resultado;

            try          // intenta ejecutar el siguiente bloque
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);

                resultado = a / b;

                lblResultado.Text = "=  " + resultado;
            }
            catch (FormatException ex)      // excepcion por FORMATO       
            {
                MessageBox.Show("Por favor, cargar solo numero...","ATENCION");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por CERO", "ATENCION");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow", "ATENCION");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido...","ATENCION");
            }
        }
    }
}
