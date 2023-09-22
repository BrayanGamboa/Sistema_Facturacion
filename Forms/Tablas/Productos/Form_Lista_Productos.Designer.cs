namespace Sistema_Facturacion.Forms.Tablas.Productos
{
    partial class Form_Lista_Productos
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
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btn_buscar_productos = new MaterialSkin.Controls.MaterialButton();
            this.txt_nombre_producto = new MaterialSkin.Controls.MaterialTextBox();
            this.btnNuevoProducto = new MaterialSkin.Controls.MaterialButton();
            this.lstProducto = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(12, 12);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 11;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(226, 32);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(467, 58);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Listado de Productos:";
            // 
            // btn_buscar_productos
            // 
            this.btn_buscar_productos.AutoSize = false;
            this.btn_buscar_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscar_productos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_buscar_productos.Depth = 0;
            this.btn_buscar_productos.HighEmphasis = true;
            this.btn_buscar_productos.Icon = null;
            this.btn_buscar_productos.Location = new System.Drawing.Point(352, 169);
            this.btn_buscar_productos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_buscar_productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar_productos.Name = "btn_buscar_productos";
            this.btn_buscar_productos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_buscar_productos.Size = new System.Drawing.Size(230, 40);
            this.btn_buscar_productos.TabIndex = 19;
            this.btn_buscar_productos.Text = "Buscar";
            this.btn_buscar_productos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_buscar_productos.UseAccentColor = false;
            this.btn_buscar_productos.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.AnimateReadOnly = false;
            this.txt_nombre_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_producto.Depth = 0;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre_producto.Hint = "Ingresa el nombre del producto:";
            this.txt_nombre_producto.LeadingIcon = null;
            this.txt_nombre_producto.Location = new System.Drawing.Point(257, 110);
            this.txt_nombre_producto.MaxLength = 50;
            this.txt_nombre_producto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre_producto.Multiline = false;
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(421, 50);
            this.txt_nombre_producto.TabIndex = 18;
            this.txt_nombre_producto.Text = "";
            this.txt_nombre_producto.TrailingIcon = null;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.AutoSize = false;
            this.btnNuevoProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoProducto.Depth = 0;
            this.btnNuevoProducto.HighEmphasis = true;
            this.btnNuevoProducto.Icon = global::Sistema_Facturacion.Properties.Resources.boton_mas;
            this.btnNuevoProducto.Location = new System.Drawing.Point(360, 508);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoProducto.Size = new System.Drawing.Size(230, 40);
            this.btnNuevoProducto.TabIndex = 21;
            this.btnNuevoProducto.Text = "Agregar Producto";
            this.btnNuevoProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoProducto.UseAccentColor = false;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // lstProducto
            // 
            this.lstProducto.BackgroundColor = System.Drawing.Color.White;
            this.lstProducto.ColumnHeadersHeight = 30;
            this.lstProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.categoria_producto,
            this.precio_producto,
            this.stock_producto,
            this.btn_editar,
            this.btn_borrar});
            this.lstProducto.Location = new System.Drawing.Point(48, 245);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(808, 254);
            this.lstProducto.TabIndex = 20;
            this.lstProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstProducto_CellContentClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.Name = "id_producto";
            this.id_producto.Width = 50;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Width = 200;
            // 
            // categoria_producto
            // 
            this.categoria_producto.HeaderText = "Categoría";
            this.categoria_producto.Name = "categoria_producto";
            this.categoria_producto.Width = 150;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.Width = 150;
            // 
            // stock_producto
            // 
            this.stock_producto.HeaderText = "Stock";
            this.stock_producto.Name = "stock_producto";
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
            // Form_Lista_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.btn_buscar_productos);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Lista_Productos";
            this.Text = "Lista de productos";
            this.Load += new System.EventHandler(this.Form_Lista_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialButton btn_buscar_productos;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre_producto;
        private MaterialSkin.Controls.MaterialButton btnNuevoProducto;
        private System.Windows.Forms.DataGridView lstProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_producto;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
    }
}