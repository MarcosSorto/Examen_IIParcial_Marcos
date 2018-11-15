﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario proncipal y cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que desea salir?", "Control de canciones", MessageBoxButtons.YesNo);

            //Verificamos la respuesta del usuario
            if (resp== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
