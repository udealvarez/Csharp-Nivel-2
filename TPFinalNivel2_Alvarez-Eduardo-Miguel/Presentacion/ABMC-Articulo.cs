using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ABMC_Articulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;


        public ABMC_Articulo()
        {
            InitializeComponent();
            Text = "Agregar articulo";
        }

        public ABMC_Articulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

    }
}
