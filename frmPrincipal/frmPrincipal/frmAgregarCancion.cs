using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// utilizamos el namespaces para acceder a la carpeta.
using frmPrincipal.Clases;

namespace frmPrincipal
{
    public partial class frmAgregarCancion : Form
    {
        public frmAgregarCancion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //verificamos que todos los datos sean ingresados
            if(txtNombre.Text =="" || txtArtista.Text==""||txtAlbum.Text=="" ||txtGenero.Text=="" || txtAnio.Text == "")
            {
                MessageBox.Show("Hay datos que aún no se ingresan. ¡Revise!", "Error en Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                // instanciamos de la clase Cancion
                Cancion nueva = new Cancion();

                // llenamos los datos correspondientes
                nueva.nombre = txtNombre.Text;
                nueva.album = Convert.ToInt16(txtAlbum.Text);
                nueva.artista = Convert.ToInt16(txtArtista.Text);
                nueva.genero = txtGenero.Text;
                nueva.anio = txtAnio.Text;

                // verificamos si la canción se insertó correctamente
                if (Cancion.InsertarCancion(nueva))
                {
                    MessageBox.Show("La canción se guardó correctamente");

                }
                else
                {
                    MessageBox.Show("Ocurrió un error durante la insersión");
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Se encarga de limpiar los datos ingresados
        /// </summary>
        public void limpiar()
        {
            txtNombre.Text = "";
            txtGenero.Text = "";
            txtAlbum.Text = "";
            txtAnio.Text = "";
            txtArtista.Text = "";
            txtNombre.Focus();
        }
    }
}
