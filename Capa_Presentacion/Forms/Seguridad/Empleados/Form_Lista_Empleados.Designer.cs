namespace Sistema_Facturacion.Forms.Seguridad.Empleados
{
    partial class Form_Lista_Empleados
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
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.lstEmpleados = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(229, 35);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(498, 58);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Listado de Empleados: ";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSize = false;
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.HighEmphasis = true;
            this.btnNuevoEmpleado.Icon = global::Sistema_Facturacion.Properties.Resources.agregar_usuario1;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(355, 517);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(230, 40);
            this.btnNuevoEmpleado.TabIndex = 21;
            this.btnNuevoEmpleado.Text = "Agregar Empleado";
            this.btnNuevoEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoEmpleado.UseAccentColor = false;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.lstEmpleados.ColumnHeadersHeight = 30;
            this.lstEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.nombre_empleado,
            this.documento_usuario,
            this.telefono_empleado,
            this.btn_editar,
            this.btn_borrar});
            this.lstEmpleados.Location = new System.Drawing.Point(81, 254);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(770, 254);
            this.lstEmpleados.TabIndex = 20;
            this.lstEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstEmpleados_CellContentClick);
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "ID";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 60;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.HeaderText = "Nombre";
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.Width = 250;
            // 
            // documento_usuario
            // 
            this.documento_usuario.HeaderText = "Documento";
            this.documento_usuario.Name = "documento_usuario";
            this.documento_usuario.Width = 150;
            // 
            // telefono_empleado
            // 
            this.telefono_empleado.HeaderText = "Teléfono";
            this.telefono_empleado.Name = "telefono_empleado";
            this.telefono_empleado.Width = 150;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "Editar";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseColumnTextForButtonValue = true;
            this.btn_editar.Width = 50;
            // 
            // btn_borrar
            // 
            this.btn_borrar.HeaderText = "Borrar";
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseColumnTextForButtonValue = true;
            this.btn_borrar.Width = 50;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AutoSize = false;
            this.btnBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.HighEmphasis = true;
            this.btnBuscarEmpleado.Icon = null;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(355, 177);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(230, 40);
            this.btnBuscarEmpleado.TabIndex = 19;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarEmpleado.UseAccentColor = false;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.Hint = "Ingresa el nombre del cliente:";
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(260, 118);
            this.txtNombreEmpleado.MaxLength = 50;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(421, 50);
            this.txtNombreEmpleado.TabIndex = 18;
            this.txtNombreEmpleado.Text = "";
            this.txtNombreEmpleado.TrailingIcon = null;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(12, 12);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 17;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // Form_Lista_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Lista_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Lista_Empleados";
            this.Load += new System.EventHandler(this.Form_Lista_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialButton btnNuevoEmpleado;
        private System.Windows.Forms.DataGridView lstEmpleados;
        private MaterialSkin.Controls.MaterialButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEmpleado;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_empleado;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
    }
}