using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Facturacion
{
    public partial class Frmlogin: Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = ""; //Creamos variable para controlar si encontró el usuario en la BD

            if (TxtUsuario.Text != "" && TxtPassword.Text != string.Empty) //Verificamos que los campos no estén vacíos

            {
                Acceso_datos Acceso = new Acceso_datos(); //Creamos el objeto para acceder a la BD
                Respuesta = Acceso.ValidarUsuario(TxtUsuario.Text, TxtPassword.Text); //Invocamos el método para validar usuario y clave


                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta);//Mostramos mensaje de Bienvenida con nombre de Usuario
                    FrmPrincipal frmppal = new FrmPrincipal(); //Creamos el objeto del formulario FrmPrincipal
                    this.Hide(); //Ocultamos el formulario Login
                    frmppal.Show(); //Mostramos el formulario Principal
                }
                else
                {
                    MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPassword.Text = "";
                }
                                
            }
            else
            {
                MessageBox.Show("Debe ingresar Usuario y Clave");
            }
        }
        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void Txtpassword_Click(object sender, EventArgs e)
        {

        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
