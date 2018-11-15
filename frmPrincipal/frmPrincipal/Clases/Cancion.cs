using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespacesNecesrios
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmPrincipal.Clases
{
    class Cancion
    {
        // definimos las propiedades de la clase
        public int id { get; set; }
        public string nombre { get; set; }
        public int artista { get; set; }
        public int album { get; set; }
        public string genero { get; set; }
        public string anio { get; set; }
        
       //Métodos necesarios

            /// <summary>
            /// Se ncarga de tomar los datos de la canción e intenta insertarlos en 
            /// la base de datos,
            /// </summary>
            /// <returns></returns>
        public static bool InsertarCancion(Cancion laCancion)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_AgregarCanciones");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 200));
            cmd.Parameters["@nombre"].Value = laCancion.nombre;

            cmd.Parameters.Add(new SqlParameter("@artista", SqlDbType.Int,10));
            cmd.Parameters["@artista"].Value = laCancion.artista;

            cmd.Parameters.Add(new SqlParameter("@album", SqlDbType.Int,10));
            cmd.Parameters["@album"].Value = laCancion.album;

            cmd.Parameters.Add(new SqlParameter("@genero", SqlDbType.NVarChar, 100));
            cmd.Parameters["@genero"].Value = laCancion.genero;

            cmd.Parameters.Add(new SqlParameter("@anio", SqlDbType.NVarChar,4));
            cmd.Parameters["@anio"].Value = laCancion.anio;

            // intentamos insertar la nueva canción
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
