namespace Sistema_Facturacion.Forms.Seguridad.Roles
{
    partial class Form_Lista_Roles
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
            this.btnNuevoRol = new MaterialSkin.Controls.MaterialButton();
            this.lstRol = new System.Windows.Forms.DataGridView();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarRol = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(284, 28);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 58);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Listado de Roles: ";
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.AutoSize = false;
            this.btnNuevoRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoRol.Depth = 0;
            this.btnNuevoRol.HighEmphasis = true;
            this.btnNuevoRol.Icon = global::Sistema_Facturacion.Properties.Resources.boton_mas;
            this.btnNuevoRol.Location = new System.Drawing.Point(355, 517);
            this.btnNuevoRol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoRol.Size = new System.Drawing.Size(230, 40);
            this.btnNuevoRol.TabIndex = 21;
            this.btnNuevoRol.Text = "Agregar Rol";
            this.btnNuevoRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoRol.UseAccentColor = false;
            this.btnNuevoRol.UseVisualStyleBackColor = true;
            this.btnNuevoRol.Click += new System.EventHandler(this.btnNuevoRol_Click);
            // 
            // lstRol
            // 
            this.lstRol.BackgroundColor = System.Drawing.Color.White;
            this.lstRol.ColumnHeadersHeight = 30;
            this.lstRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rol,
            this.nombre_rol,
            this.btn_editar,
            this.btn_borrar});
            this.lstRol.Location = new System.Drawing.Point(239, 241);
            this.lstRol.Name = "lstRol";
            this.lstRol.Size = new System.Drawing.Size(471, 254);
            this.lstRol.TabIndex = 20;
            this.lstRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstRol_CellContentClick);
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "ID";
            this.id_rol.Name = "id_rol";
            this.id_rol.Width = 60;
            // 
            // nombre_rol
            // 
            this.nombre_rol.HeaderText = "Nombre Rol";
            this.nombre_rol.Name = "nombre_rol";
            this.nombre_rol.Width = 250;
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
            // btnBuscarRol
            // 
            this.btnBuscarRol.AutoSize = false;
            this.btnBuscarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarRol.Depth = 0;
            this.btnBuscarRol.HighEmphasis = true;
            this.btnBuscarRol.Icon = null;
            this.btnBuscarRol.Location = new System.Drawing.Point(355, 177);
            this.btnBuscarRol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarRol.Size = new System.Drawing.Size(230, 40);
            this.btnBuscarRol.TabIndex = 19;
            this.btnBuscarRol.Text = "Buscar";
            this.btnBuscarRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarRol.UseAccentColor = false;
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.AnimateReadOnly = false;
            this.txtNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreRol.Hint = "Ingresa el nombre del rol:";
            this.txtNombreRol.LeadingIcon = null;
            this.txtNombreRol.Location = new System.Drawing.Point(260, 118);
            this.txtNombreRol.MaxLength = 50;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreRol.Multiline = false;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(421, 50);
            this.txtNombreRol.TabIndex = 18;
            this.txtNombreRol.Text = "";
            this.txtNombreRol.TrailingIcon = null;
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
            // Form_Lista_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevoRol);
            this.Controls.Add(this.lstRol);
            this.Controls.Add(this.btnBuscarRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Lista_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de roles";
            this.Load += new System.EventHandler(this.Form_Lista_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialButton btnNuevoRol;
        private System.Windows.Forms.DataGridView lstRol;
        private MaterialSkin.Controls.MaterialButton btnBuscarRol;
        private MaterialSkin.Controls.MaterialTextBox txtNombreRol;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_rol;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
    }
}