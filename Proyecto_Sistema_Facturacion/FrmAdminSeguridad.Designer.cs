namespace Proyecto_Sistema_Facturacion
{
    partial class FrmAdminSeguridad
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
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbDatosbasicos = new System.Windows.Forms.GroupBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.gpbDatosbasicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(680, 398);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(69, 36);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            //this.BtnSalir.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(680, 177);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(680, 97);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(78, 36);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(680, 266);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(100, 36);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // gpbDatosbasicos
            // 
            this.gpbDatosbasicos.Controls.Add(this.txtPassword);
            this.gpbDatosbasicos.Controls.Add(this.txtUsuario);
            this.gpbDatosbasicos.Controls.Add(this.cboEmpleado);
            this.gpbDatosbasicos.Controls.Add(this.materialLabel5);
            this.gpbDatosbasicos.Location = new System.Drawing.Point(27, 108);
            this.gpbDatosbasicos.Name = "gpbDatosbasicos";
            this.gpbDatosbasicos.Size = new System.Drawing.Size(613, 286);
            this.gpbDatosbasicos.TabIndex = 12;
            this.gpbDatosbasicos.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(195, 166);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(318, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(195, 116);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(318, 28);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(171, 36);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(359, 24);
            this.cboEmpleado.TabIndex = 13;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(38, 36);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 24);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(108, 30);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(648, 37);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // FrmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 602);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gpbDatosbasicos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminSeguridad";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.frmAdminSeguridad_Load);
            this.gpbDatosbasicos.ResumeLayout(false);
            this.gpbDatosbasicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private System.Windows.Forms.GroupBox gpbDatosbasicos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}