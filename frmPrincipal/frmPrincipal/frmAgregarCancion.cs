using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
            if (txtNombre.Text == "" ||lstArtista.SelectedIndex ==-1 || lstAlbum.SelectedIndex ==-1|| txtGenero.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Hay datos que aún no se ingresan. ¡Revise!", "Error en Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                // instanciamos de la clase Cancion
                Cancion nueva = new Cancion();

                // llenamos los datos correspondientes
                nueva.nombre = txtNombre.Text;
                nueva.album = lstAlbum.SelectedItem.ToString();
                nueva.artista = lstArtista.SelectedItem.ToString();
                nueva.genero = txtGenero.Text;
                nueva.anio = txtAnio.Text;

                // verificamos si la canción se insertó correctamente
                if (Cancion.InsertarCancion(nueva))
                {
                    MessageBox.Show("La canción se guardó correctamente");
                    limpiar();
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
            lstArtista.SelectedIndex = -1;
            txtAnio.Text = "";
            lstAlbum.SelectedIndex = -1;
            txtNombre.Focus();
        }

        /// <summary>
        /// se encarga de inicializar y cargar los datos en las listas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgregarCancion_Load(object sender, EventArgs e)
        {

            llenarAlbum();
            LlenarArtista();

        }
        public void llenarAlbum()
        {
            //instanciamos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");

            //definimos el query
            string sql = "Select Nombre FROM Music.Album";

            //definimos el commando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // establecemos conexion
                conn.EstablecerConexion();

                // Ejecutamos el query via un DataReader y llenamos el listbox
                SqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    lstAlbum.Items.Add(rdr[0].ToString());
                    lstAlbum.Items.Add("\n");

                }


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepcion");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public void LlenarArtista()
        {
            //instanciamos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");

            //definimos el query
            string sql1 = "Select Nombre FROM Music.Artista WHERE Estado = 1";

            //definimos el commando
            SqlCommand cmd1 = conn.EjecutarComando(sql1);
            try
            {
                // establecemos conexion
                conn.EstablecerConexion();

                // Ejecutamos el query via un DataReader y llenamos el listbox
                SqlDataReader rdr = cmd1.ExecuteReader();

                while (rdr.Read())
                {
                    lstArtista.Items.Add(rdr[0].ToString());
                    lstArtista.Items.Add("\n");

                }
             


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepcion");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
    }

