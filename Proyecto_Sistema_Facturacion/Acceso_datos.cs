using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sistema_Facturacion
{
    class Acceso_datos
    {
        SqlConnection conexion; //Se define la variable para la conexion de tipo SqlConnection
        SqlCommand cmd;//se define la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null; //data reader, consulta de solo lectura de la información
        //SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd() // método para abrir la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de conexión
                conexion = new SqlConnection("Data Source=JOHNDASH24\\SQLEXPRESS;Initial Catalog=[DBFACTURAS];Integrated Security=True");
                conexion.Open(); // invocamos método para abrir la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló conexión " + ex);
            }
        }
        public void CerrarrBd() // método para cerrar la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para cerrar la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló cerrar conexión " + ex);
            }
        }

        // ============== Método para validar el ingreso del usuario al sistema ===============================//

    public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros de control
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // otros tipos son :CommandType.StoredProcedure  CommandType.TableDirect
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader(); // ejecuta y retorna un conjunto de datos no actualizable
                while (LectorDatos.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) // cerramos el lector de datos
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        // ------- recibe una sentencia de para realizar acciones de actualizar, retirar y nuevo
        // solo retorna un valor numerico que indica cuantas filas fueron afectadas
        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE!";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); // UTILIZADO PARA UPDATE, INSERT y DELETE
                CerrarrBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "falló inserción: " + ex;
            }
            return salida;
        }
        // Método que permite consultar una tabla y recuperar un conjunto de datos permite filtrar la información requerida
        public DataTable cargartabla(string tabla, string strCondicion)
        {
            DataTable dt = new DataTable();
            try
            {
                AbrirBd(); // Intenta abrir la conexión
                if (conexion.State == ConnectionState.Open)
                {
                    // La conexión está abierta correctamente
                    string query = $"SELECT * FROM {tabla} {strCondicion}";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    da.Fill(dt);
                }
                else
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                CerrarrBd(); // Cierra la conexión
            }
            return dt;
        }
        
        // Método que permite consultar con una sentencia (select) o invocar un procedimiento almacenado
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarrBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }
    }
}
