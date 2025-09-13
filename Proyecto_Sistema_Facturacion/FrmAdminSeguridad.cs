using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;    

namespace Proyecto_Sistema_Facturacion
{
    public partial class FrmAdminSeguridad: Form
    {
        private ErrorProvider MensajeError = new ErrorProvider();

        public FrmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.cargartabla("TBLEMPLEADO", "");
            cboEmpleado.DataSource = dt;
            cboEmpleado.DisplayMember = "strNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
            Acceso.CerrarrBd();
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "debe ingresar un valor de Usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuario, ""); }
            if (txtPassword.Text == "")
            {
                MensajeError.SetError(txtPassword, "Debe ingresar un valor de cédula");
                txtPassword.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtPassword, ""); }
            return errorCampos;
        }
        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
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
        // función que permite guardar los datos de ingreso a un usuario
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Seguridad '{Convert.ToInt32(cboEmpleado.SelectedValue)}','{txtUsuario.Text}','{txtPassword.Text}','{DateTime.Now}','Javier'";
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
        // función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Seguridad '{Convert.ToInt32(cboEmpleado.SelectedValue)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }
        // función que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            DataTable dt = new DataTable();
            string sentencia = "select StrUsuario,StrClave from TBLSEGURIDAD where IdEmpleado=" +
           cboEmpleado.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.EjecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                txtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtPassword.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }
        private void FrmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}




        

