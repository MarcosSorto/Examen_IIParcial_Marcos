using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//namespaces necesarios
using System.Data;
using System.Data.SqlClient;
using frmPrincipal.Clases;

namespace frmPrincipal
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Regresa al formulario Principla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            //instanciamos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");

            //definimos el query
            string sql = "Select Nombre FROM Music.Cancion";

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
                    lstEliminar.Items.Add(rdr[0].ToString());

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEliminar.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la canción");

            }
            else
            {

            }
            
        }
    }
}
