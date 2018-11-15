using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespaces que necesitamos
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmPrincipal.Clases
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        // Constructores
        public Conexion() { }

        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }

        /// <summary>
        /// Establece la conexión al servidor y a la base especificada.
        /// </summary>
        public void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"server = " + servidor + ";" +
                    "integrated security = true; database = " + baseDatos + ";");

                // Establecer conexión
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("¡Servidor o base de datos erróneos!");
            }
        }

        public SqlCommand EjecutarComando(string elComando)
        {
            return cmd = new SqlCommand(elComando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor.
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
