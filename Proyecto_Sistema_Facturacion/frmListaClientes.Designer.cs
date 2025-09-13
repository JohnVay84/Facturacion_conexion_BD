namespace Proyecto_Sistema_Facturacion
{
    partial class frmListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrUsuarioModifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(314, 9);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN CLIENTES";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(348, 69);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(24, 434);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 36);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(465, 434);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.StrNombre,
            this.NumDocumento,
            this.StrDireccion,
            this.StrTelefono,
            this.StrEmail,
            this.DtmFechaModifica,
            this.StrUsuarioModifico,
            this.btnEditar,
            this.btnBorrar});
            this.dgClientes.Location = new System.Drawing.Point(24, 120);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(757, 296);
            this.dgClientes.TabIndex = 2;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdCliente.HeaderText = "ID";
            this.IdCliente.MaxInputLength = 50;
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdCliente.Width = 49;
            // 
            // StrNombre
            // 
            this.StrNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StrNombre.HeaderText = "NOMBRE";
            this.StrNombre.MaxInputLength = 50;
            this.StrNombre.MinimumWidth = 6;
            this.StrNombre.Name = "StrNombre";
            this.StrNombre.ReadOnly = true;
            this.StrNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StrNombre.Width = 95;
            // 
            // NumDocumento
            // 
            this.NumDocumento.HeaderText = "DOCUMENTO";
            this.NumDocumento.MinimumWidth = 6;
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.Width = 80;
            // 
            // StrDireccion
            // 
            this.StrDireccion.HeaderText = "DIRECCIÓN";
            this.StrDireccion.MinimumWidth = 6;
            this.StrDireccion.Name = "StrDireccion";
            this.StrDireccion.Width = 125;
            // 
            // StrTelefono
            // 
            this.StrTelefono.HeaderText = "TELÉFONO";
            this.StrTelefono.MinimumWidth = 6;
            this.StrTelefono.Name = "StrTelefono";
            this.StrTelefono.Width = 80;
            // 
            // StrEmail
            // 
            this.StrEmail.HeaderText = "CORREO";
            this.StrEmail.MinimumWidth = 6;
            this.StrEmail.Name = "StrEmail";
            this.StrEmail.Visible = false;
            this.StrEmail.Width = 125;
            // 
            // DtmFechaModifica
            // 
            this.DtmFechaModifica.HeaderText = "FECHA MODIFICACION";
            this.DtmFechaModifica.MinimumWidth = 6;
            this.DtmFechaModifica.Name = "DtmFechaModifica";
            this.DtmFechaModifica.Visible = false;
            this.DtmFechaModifica.Width = 125;
            // 
            // StrUsuarioModifico
            // 
            this.StrUsuarioModifico.HeaderText = "USUARIO MODIFICA";
            this.StrUsuarioModifico.MinimumWidth = 6;
            this.StrUsuarioModifico.Name = "StrUsuarioModifico";
            this.StrUsuarioModifico.Visible = false;
            this.StrUsuarioModifico.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar por Cliente";
            this.txtBuscar.Location = new System.Drawing.Point(24, 77);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(298, 28);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 596);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaClientes";
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFechaModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrUsuarioModifico;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}