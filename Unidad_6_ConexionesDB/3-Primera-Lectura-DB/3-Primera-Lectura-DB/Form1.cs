﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Primera_Lectura_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemons.DataSource = negocio.listar();

            // DataSource -> RECIBE UN origen de datos y lo muestra en el datagrid

            /*
             *  que hace negocio.listar() ?? VA A LA BASE DE DATOSY TE DEVUELVE UNA LISTA DE DATOS
             */

        }
    }
}
