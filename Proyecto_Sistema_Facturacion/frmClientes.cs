using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Facturacion
{
    public partial class FrmClientes : MaterialForm
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        public int IdCliente { get; set; } // ATRIBUTO QUE PERMITE RECIBIR COMO PARAMETRO EL iDcLIENTE

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
        private ErrorProvider MensajeError = new ErrorProvider();
        private void LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {
                // ES UN REGISTRO NUEVO
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                string sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}"; // CONSULTO REGISTRO DEL iDcLIENTE

                 dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
        }
        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
 public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{txtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','Javier','{DateTime.Now.ToShortDateString()}'";
                MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debeingresar el nombre del Cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }
            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }
            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");

                txtDocumento.Focus();
                return false;
            }

            MensajeError.SetError(txtDocumento, "");
            return errorCampos;
        }
    
         //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
