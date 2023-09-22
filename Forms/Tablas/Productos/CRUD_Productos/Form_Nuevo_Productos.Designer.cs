namespace Sistema_Facturacion.Forms
{
    partial class Form_Nuevo_Productos
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
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoReferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.txtRutaImg = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.txtDetalles = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AnimateReadOnly = false;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProducto.Hint = "Nombre del producto";
            this.txtNombreProducto.LeadingIcon = null;
            this.txtNombreProducto.Location = new System.Drawing.Point(86, 184);
            this.txtNombreProducto.MaxLength = 50;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(403, 50);
            this.txtNombreProducto.TabIndex = 7;
            this.txtNombreProducto.Text = "";
            this.txtNombreProducto.TrailingIcon = null;
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.AnimateReadOnly = false;
            this.txtCodigoReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoReferencia.Depth = 0;
            this.txtCodigoReferencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoReferencia.Hint = "Código de referencia";
            this.txtCodigoReferencia.LeadingIcon = null;
            this.txtCodigoReferencia.Location = new System.Drawing.Point(86, 244);
            this.txtCodigoReferencia.MaxLength = 50;
            this.txtCodigoReferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoReferencia.Multiline = false;
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.Size = new System.Drawing.Size(403, 50);
            this.txtCodigoReferencia.TabIndex = 8;
            this.txtCodigoReferencia.Text = "";
            this.txtCodigoReferencia.TrailingIcon = null;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.AnimateReadOnly = false;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCompra.Hint = "Precio compra";
            this.txtPrecioCompra.LeadingIcon = null;
            this.txtPrecioCompra.Location = new System.Drawing.Point(86, 304);
            this.txtPrecioCompra.MaxLength = 50;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(403, 50);
            this.txtPrecioCompra.TabIndex = 9;
            this.txtPrecioCompra.Text = "";
            this.txtPrecioCompra.TrailingIcon = null;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AnimateReadOnly = false;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioVenta.Hint = "Precio de venta";
            this.txtPrecioVenta.LeadingIcon = null;
            this.txtPrecioVenta.Location = new System.Drawing.Point(86, 364);
            this.txtPrecioVenta.MaxLength = 50;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(403, 50);
            this.txtPrecioVenta.TabIndex = 10;
            this.txtPrecioVenta.Text = "";
            this.txtPrecioVenta.TrailingIcon = null;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(355, 509);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(230, 40);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(86, 424);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(403, 50);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoResize = false;
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCategoria.Depth = 0;
            this.txtCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtCategoria.DropDownHeight = 174;
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.DropDownWidth = 121;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Hint = "Categoría";
            this.txtCategoria.IntegralHeight = false;
            this.txtCategoria.ItemHeight = 43;
            this.txtCategoria.Location = new System.Drawing.Point(532, 185);
            this.txtCategoria.MaxDropDownItems = 4;
            this.txtCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(322, 49);
            this.txtCategoria.StartIndex = 0;
            this.txtCategoria.TabIndex = 13;
            // 
            // txtRutaImg
            // 
            this.txtRutaImg.AnimateReadOnly = false;
            this.txtRutaImg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaImg.Depth = 0;
            this.txtRutaImg.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRutaImg.Hint = "Ruta de la Img";
            this.txtRutaImg.LeadingIcon = null;
            this.txtRutaImg.Location = new System.Drawing.Point(532, 244);
            this.txtRutaImg.MaxLength = 50;
            this.txtRutaImg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRutaImg.Multiline = false;
            this.txtRutaImg.Name = "txtRutaImg";
            this.txtRutaImg.Size = new System.Drawing.Size(322, 50);
            this.txtRutaImg.TabIndex = 14;
            this.txtRutaImg.Text = "";
            this.txtRutaImg.TrailingIcon = null;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(6, 67);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 6;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.AnimateReadOnly = false;
            this.txtDetalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDetalles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetalles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalles.Depth = 0;
            this.txtDetalles.HideSelection = true;
            this.txtDetalles.Hint = "Detalles del producto:";
            this.txtDetalles.Location = new System.Drawing.Point(532, 304);
            this.txtDetalles.MaxLength = 32767;
            this.txtDetalles.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.PasswordChar = '\0';
            this.txtDetalles.ReadOnly = false;
            this.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetalles.SelectedText = "";
            this.txtDetalles.SelectionLength = 0;
            this.txtDetalles.SelectionStart = 0;
            this.txtDetalles.ShortcutsEnabled = true;
            this.txtDetalles.Size = new System.Drawing.Size(322, 170);
            this.txtDetalles.TabIndex = 19;
            this.txtDetalles.TabStop = false;
            this.txtDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetalles.UseSystemPasswordChar = false;
            // 
            // Form_Nuevo_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.txtRutaImg);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodigoReferencia);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Nuevo_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar productos";
            this.Load += new System.EventHandler(this.Form_Nuevo_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtNombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoReferencia;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompra;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioVenta;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialComboBox txtCategoria;
        private MaterialSkin.Controls.MaterialTextBox txtRutaImg;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetalles;
    }
}