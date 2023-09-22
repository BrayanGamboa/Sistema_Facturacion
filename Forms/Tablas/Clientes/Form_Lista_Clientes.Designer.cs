namespace Sistema_Facturacion.Forms
{
    partial class Form_Lista_Clientes
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
            this.lstClientes = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_buscar_usuario = new MaterialSkin.Controls.MaterialButton();
            this.txt_nombre_usuario = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.btn_nuevo_usuario = new MaterialSkin.Controls.MaterialButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lstClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.BackgroundColor = System.Drawing.Color.White;
            this.lstClientes.ColumnHeadersHeight = 30;
            this.lstClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre_usuario,
            this.documento_usuario,
            this.telefono_usuario,
            this.btn_editar,
            this.btn_borrar});
            this.lstClientes.Location = new System.Drawing.Point(81, 254);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(770, 254);
            this.lstClientes.TabIndex = 13;
            this.lstClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_clientes_CellContentClick_1);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Width = 60;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Nombre";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Width = 250;
            // 
            // documento_usuario
            // 
            this.documento_usuario.HeaderText = "Documento";
            this.documento_usuario.Name = "documento_usuario";
            this.documento_usuario.Width = 150;
            // 
            // telefono_usuario
            // 
            this.telefono_usuario.HeaderText = "Teléfono";
            this.telefono_usuario.Name = "telefono_usuario";
            this.telefono_usuario.Width = 150;
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
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.AutoSize = false;
            this.btn_buscar_usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscar_usuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_buscar_usuario.Depth = 0;
            this.btn_buscar_usuario.HighEmphasis = true;
            this.btn_buscar_usuario.Icon = null;
            this.btn_buscar_usuario.Location = new System.Drawing.Point(355, 177);
            this.btn_buscar_usuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_buscar_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_buscar_usuario.Size = new System.Drawing.Size(230, 40);
            this.btn_buscar_usuario.TabIndex = 12;
            this.btn_buscar_usuario.Text = "Buscar";
            this.btn_buscar_usuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_buscar_usuario.UseAccentColor = false;
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.AnimateReadOnly = false;
            this.txt_nombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_usuario.Depth = 0;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre_usuario.Hint = "Ingresa el nombre del cliente:";
            this.txt_nombre_usuario.LeadingIcon = null;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(260, 118);
            this.txt_nombre_usuario.MaxLength = 50;
            this.txt_nombre_usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre_usuario.Multiline = false;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(421, 50);
            this.txt_nombre_usuario.TabIndex = 11;
            this.txt_nombre_usuario.Text = "";
            this.txt_nombre_usuario.TrailingIcon = null;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(12, 12);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 10;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click_1);
            // 
            // btn_nuevo_usuario
            // 
            this.btn_nuevo_usuario.AutoSize = false;
            this.btn_nuevo_usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo_usuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_nuevo_usuario.Depth = 0;
            this.btn_nuevo_usuario.HighEmphasis = true;
            this.btn_nuevo_usuario.Icon = global::Sistema_Facturacion.Properties.Resources.agregar_usuario1;
            this.btn_nuevo_usuario.Location = new System.Drawing.Point(355, 517);
            this.btn_nuevo_usuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_nuevo_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_nuevo_usuario.Name = "btn_nuevo_usuario";
            this.btn_nuevo_usuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_nuevo_usuario.Size = new System.Drawing.Size(230, 40);
            this.btn_nuevo_usuario.TabIndex = 14;
            this.btn_nuevo_usuario.Text = "Agregar Usuario";
            this.btn_nuevo_usuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_nuevo_usuario.UseAccentColor = false;
            this.btn_nuevo_usuario.UseVisualStyleBackColor = true;
            this.btn_nuevo_usuario.Click += new System.EventHandler(this.btn_nuevo_usuario_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(274, 34);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(407, 58);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Listado de Cliente: ";
            // 
            // Form_Lista_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btn_nuevo_usuario);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btn_buscar_usuario);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Lista_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.Form_Lista_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_usuario;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
        private MaterialSkin.Controls.MaterialButton btn_buscar_usuario;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre_usuario;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialButton btn_nuevo_usuario;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}