namespace Sistema_Facturacion.Forms.Tablas
{
    partial class Form_Lista_Categoria
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
            this.btn_nueva_categoria = new MaterialSkin.Controls.MaterialButton();
            this.lstCategorias = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(224, 32);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(491, 58);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Listado de Categorías: ";
            // 
            // btn_nueva_categoria
            // 
            this.btn_nueva_categoria.AutoSize = false;
            this.btn_nueva_categoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nueva_categoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_nueva_categoria.Depth = 0;
            this.btn_nueva_categoria.HighEmphasis = true;
            this.btn_nueva_categoria.Icon = global::Sistema_Facturacion.Properties.Resources.boton_mas;
            this.btn_nueva_categoria.Location = new System.Drawing.Point(355, 517);
            this.btn_nueva_categoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_nueva_categoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_nueva_categoria.Name = "btn_nueva_categoria";
            this.btn_nueva_categoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_nueva_categoria.Size = new System.Drawing.Size(230, 40);
            this.btn_nueva_categoria.TabIndex = 21;
            this.btn_nueva_categoria.Text = "Agregar Categoria";
            this.btn_nueva_categoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_nueva_categoria.UseAccentColor = false;
            this.btn_nueva_categoria.UseVisualStyleBackColor = true;
            this.btn_nueva_categoria.Click += new System.EventHandler(this.btn_nueva_categoria_Click);
            // 
            // lstCategorias
            // 
            this.lstCategorias.BackgroundColor = System.Drawing.Color.White;
            this.lstCategorias.ColumnHeadersHeight = 30;
            this.lstCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.nombre_categoria,
            this.btn_editar,
            this.btn_borrar});
            this.lstCategorias.Location = new System.Drawing.Point(197, 239);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(567, 254);
            this.lstCategorias.TabIndex = 20;
            this.lstCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstCategorias_CellContentClick);
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Width = 60;
            // 
            // nombre_categoria
            // 
            this.nombre_categoria.HeaderText = "Nombre categoría";
            this.nombre_categoria.Name = "nombre_categoria";
            this.nombre_categoria.Width = 350;
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
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AutoSize = false;
            this.btnBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.HighEmphasis = true;
            this.btnBuscarCategoria.Icon = null;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(355, 177);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(230, 40);
            this.btnBuscarCategoria.TabIndex = 19;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarCategoria.UseAccentColor = false;
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.AnimateReadOnly = false;
            this.txtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCategoria.Hint = "Ingresa el nombre de la categoría:";
            this.txtNombreCategoria.LeadingIcon = null;
            this.txtNombreCategoria.Location = new System.Drawing.Point(260, 118);
            this.txtNombreCategoria.MaxLength = 50;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCategoria.Multiline = false;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(421, 50);
            this.txtNombreCategoria.TabIndex = 18;
            this.txtNombreCategoria.Text = "";
            this.txtNombreCategoria.TrailingIcon = null;
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
            // Form_Lista_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btn_nueva_categoria);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Lista_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Lista_Categoria";
            this.Load += new System.EventHandler(this.Form_Lista_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialButton btn_nueva_categoria;
        private System.Windows.Forms.DataGridView lstCategorias;
        private MaterialSkin.Controls.MaterialButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCategoria;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
    }
}