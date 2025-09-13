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
    public partial class frmListaClientes: Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable(); //Tabla para almacenar los datos de los clientes
        Acceso_datos Acceso = new Acceso_datos(); //Objeto para acceder a la base de datos
        private void LLENAR_GRID() //Método para llenar el GridView con los datos
        {
            dgClientes.Rows.Clear(); //Limpiar el GridView

            string sentencia = $"SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono FROM TBLClientes"; //Sentencia SQL para obtener los datos de los clientes
            dt = Acceso.EjecutarComandoDatos(sentencia); //Ejecutar la sentencia y almacenar los datos en la tabla
            foreach (DataRow row in dt.Rows) //Recorrer las filas de la tabla
            dgClientes.Rows.Add(row[0], row[1], row[2], row[3]); //Agregar los datos al GridView
            
        }
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            LLENAR_GRID ();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgClientes.Rows.Clear();//Limpiar el GridView
                string sentencia = $"SELECT * from TBLCLIENTES where StrNombre LIKE '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//Ejecutamos la consulta
                foreach (DataRow row in dt.Rows) { dgClientes.Rows.Add(row[0], row[1], row[2], row[3]); } //Llenamos el GridView
            }
            else
            {
                LLENAR_GRID();
            }
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientes Cliente= new FrmClientes(); // Creamos el objeto de formulario de edición  //frmEditarCliente o frmListaClientes?????????
            Cliente.IdCliente = 0; // Indicamos que es un nuevo cliente
            Cliente.ShowDialog(); // Mostramos el formulario de edición
            LLENAR_GRID(); // Cuando sale de la ventana mostramos de nuevo el grid para ver el registro ingresado
        }
        
void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int posActual = dgClientes.CurrentRow.Index; // Identificamos la fila seleccionada

            // Verificamos si el botón presionado es el de Editar
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                // Abrimos el formulario de edición (asegúrate de que frmEditarCliente existe y está referenciado)
                FrmClientes cliente = new FrmClientes();

                cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                cliente.ShowDialog();
                //frmEditarCliente cliente = new frmEditarCliente();
                //if (int.TryParse(dgClientes.Rows[posActual].Cells[0].Value?.ToString(), out int idCliente))
                //{
                //    cliente.IdCliente = idCliente;
                //}
                //else
                //{
                //    MessageBox.Show("Invalid client ID format.");
                //}
                //cliente.IdCliente = Convert.ToInt32(dgClientes.Rows[posActual].Cells[0].Value);
                //cliente.ShowDialog();
                LLENAR_GRID(); // Actualizamos la lista después de editar
                //return;
            }

            // Verificamos si el botón presionado es el de BORRAR
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index; // Identificamos la fila seleccionada
                if (MessageBox.Show($"¿Seguro de borrar al cliente? {dgClientes[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                    string sentencia = $"Exec ELIMINAR_CLIENTE '{IdCliente}'";
                    string Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                    LLENAR_GRID(); // Actualizamos la lista después de eliminar
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    // Si la clase no existe, crea el archivo frmEditarCliente.cs con el siguiente contenido:
    public class frmEditarCliente : Form
    {
        public int IdCliente { get; set; }
        public frmEditarCliente()
        {
            // Inicialización del formulario
        }
    }

   }

