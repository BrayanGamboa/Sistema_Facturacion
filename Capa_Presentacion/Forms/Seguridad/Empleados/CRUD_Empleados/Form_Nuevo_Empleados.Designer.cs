namespace Sistema_Facturacion.Forms.Seguridad
{
    partial class Form_Nuevo_Empleados
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
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefonoEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.lblIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtRolEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNotas = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.fechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblRetiro = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.Hint = "Nombre empleado";
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(139, 180);
            this.txtNombreEmpleado.MaxLength = 50;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(300, 50);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.Text = "";
            this.txtNombreEmpleado.TrailingIcon = null;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(6, 67);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 8;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.AnimateReadOnly = false;
            this.txtDocumentoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumentoEmpleado.Hint = "Documento";
            this.txtDocumentoEmpleado.LeadingIcon = null;
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(139, 236);
            this.txtDocumentoEmpleado.MaxLength = 50;
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumentoEmpleado.Multiline = false;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(300, 50);
            this.txtDocumentoEmpleado.TabIndex = 9;
            this.txtDocumentoEmpleado.Text = "";
            this.txtDocumentoEmpleado.TrailingIcon = null;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.AnimateReadOnly = false;
            this.txtTelefonoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoEmpleado.Depth = 0;
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoEmpleado.Hint = "Teléfono";
            this.txtTelefonoEmpleado.LeadingIcon = null;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(139, 348);
            this.txtTelefonoEmpleado.MaxLength = 50;
            this.txtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoEmpleado.Multiline = false;
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(300, 50);
            this.txtTelefonoEmpleado.TabIndex = 10;
            this.txtTelefonoEmpleado.Text = "";
            this.txtTelefonoEmpleado.TrailingIcon = null;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.AnimateReadOnly = false;
            this.txtDireccionEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionEmpleado.Hint = "Dirección";
            this.txtDireccionEmpleado.LeadingIcon = null;
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(139, 292);
            this.txtDireccionEmpleado.MaxLength = 50;
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccionEmpleado.Multiline = false;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(300, 50);
            this.txtDireccionEmpleado.TabIndex = 11;
            this.txtDireccionEmpleado.Text = "";
            this.txtDireccionEmpleado.TrailingIcon = null;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.AnimateReadOnly = false;
            this.txtEmailEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.LeadingIcon = null;
            this.txtEmailEmpleado.Location = new System.Drawing.Point(139, 404);
            this.txtEmailEmpleado.MaxLength = 50;
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmailEmpleado.Multiline = false;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.Size = new System.Drawing.Size(300, 50);
            this.txtEmailEmpleado.TabIndex = 12;
            this.txtEmailEmpleado.Text = "";
            this.txtEmailEmpleado.TrailingIcon = null;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Depth = 0;
            this.lblIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIngreso.Location = new System.Drawing.Point(491, 180);
            this.lblIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(125, 19);
            this.lblIngreso.TabIndex = 18;
            this.lblIngreso.Text = "Fecha de ingreso:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(491, 204);
            this.fechaIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(306, 20);
            this.fechaIngreso.TabIndex = 17;
            // 
            // txtRolEmpleado
            // 
            this.txtRolEmpleado.AutoResize = false;
            this.txtRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRolEmpleado.Depth = 0;
            this.txtRolEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtRolEmpleado.DropDownHeight = 174;
            this.txtRolEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRolEmpleado.DropDownWidth = 121;
            this.txtRolEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRolEmpleado.FormattingEnabled = true;
            this.txtRolEmpleado.Hint = "Rol empleado";
            this.txtRolEmpleado.IntegralHeight = false;
            this.txtRolEmpleado.ItemHeight = 43;
            this.txtRolEmpleado.Location = new System.Drawing.Point(491, 293);
            this.txtRolEmpleado.MaxDropDownItems = 4;
            this.txtRolEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRolEmpleado.Name = "txtRolEmpleado";
            this.txtRolEmpleado.Size = new System.Drawing.Size(306, 49);
            this.txtRolEmpleado.StartIndex = 0;
            this.txtRolEmpleado.TabIndex = 19;
            // 
            // txtNotas
            // 
            this.txtNotas.AnimateReadOnly = false;
            this.txtNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotas.Depth = 0;
            this.txtNotas.HideSelection = true;
            this.txtNotas.Hint = "Datos adicionales:";
            this.txtNotas.Location = new System.Drawing.Point(491, 348);
            this.txtNotas.MaxLength = 32767;
            this.txtNotas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.PasswordChar = '\0';
            this.txtNotas.ReadOnly = false;
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotas.SelectedText = "";
            this.txtNotas.SelectionLength = 0;
            this.txtNotas.SelectionStart = 0;
            this.txtNotas.ShortcutsEnabled = true;
            this.txtNotas.Size = new System.Drawing.Size(306, 106);
            this.txtNotas.TabIndex = 22;
            this.txtNotas.TabStop = false;
            this.txtNotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNotas.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(344, 497);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(230, 36);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // fechaRetiro
            // 
            this.fechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRetiro.Location = new System.Drawing.Point(491, 260);
            this.fechaRetiro.Margin = new System.Windows.Forms.Padding(5);
            this.fechaRetiro.Name = "fechaRetiro";
            this.fechaRetiro.Size = new System.Drawing.Size(306, 20);
            this.fechaRetiro.TabIndex = 20;
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Depth = 0;
            this.lblRetiro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRetiro.Location = new System.Drawing.Point(491, 236);
            this.lblRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(109, 19);
            this.lblRetiro.TabIndex = 21;
            this.lblRetiro.Text = "Fecha de retiro:";
            // 
            // Form_Nuevo_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.fechaRetiro);
            this.Controls.Add(this.txtRolEmpleado);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.txtEmailEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtDocumentoEmpleado);
            this.Controls.Add(this.img_salir);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "Form_Nuevo_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleados";
            this.Load += new System.EventHandler(this.Form_Nuevo_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtNombreEmpleado;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblIngreso;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private MaterialSkin.Controls.MaterialComboBox txtRolEmpleado;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNotas;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.DateTimePicker fechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblRetiro;
    }
}