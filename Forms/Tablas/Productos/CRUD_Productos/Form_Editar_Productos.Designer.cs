namespace Sistema_Facturacion.Forms
{
    partial class Form_Editar_Productos
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
            this.txtCodigoReferenciaProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioCompraProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCategoriaProducto = new MaterialSkin.Controls.MaterialComboBox();
            this.txtRutaImg = new MaterialSkin.Controls.MaterialTextBox();
            this.lblIdProducto = new MaterialSkin.Controls.MaterialLabel();
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
            // txtCodigoReferenciaProducto
            // 
            this.txtCodigoReferenciaProducto.AnimateReadOnly = false;
            this.txtCodigoReferenciaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoReferenciaProducto.Depth = 0;
            this.txtCodigoReferenciaProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoReferenciaProducto.Hint = "Código de referencia";
            this.txtCodigoReferenciaProducto.LeadingIcon = null;
            this.txtCodigoReferenciaProducto.Location = new System.Drawing.Point(86, 244);
            this.txtCodigoReferenciaProducto.MaxLength = 50;
            this.txtCodigoReferenciaProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoReferenciaProducto.Multiline = false;
            this.txtCodigoReferenciaProducto.Name = "txtCodigoReferenciaProducto";
            this.txtCodigoReferenciaProducto.Size = new System.Drawing.Size(403, 50);
            this.txtCodigoReferenciaProducto.TabIndex = 8;
            this.txtCodigoReferenciaProducto.Text = "";
            this.txtCodigoReferenciaProducto.TrailingIcon = null;
            // 
            // txtPrecioCompraProducto
            // 
            this.txtPrecioCompraProducto.AnimateReadOnly = false;
            this.txtPrecioCompraProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompraProducto.Depth = 0;
            this.txtPrecioCompraProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCompraProducto.Hint = "Precio compra";
            this.txtPrecioCompraProducto.LeadingIcon = null;
            this.txtPrecioCompraProducto.Location = new System.Drawing.Point(86, 304);
            this.txtPrecioCompraProducto.MaxLength = 50;
            this.txtPrecioCompraProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioCompraProducto.Multiline = false;
            this.txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            this.txtPrecioCompraProducto.Size = new System.Drawing.Size(403, 50);
            this.txtPrecioCompraProducto.TabIndex = 9;
            this.txtPrecioCompraProducto.Text = "";
            this.txtPrecioCompraProducto.TrailingIcon = null;
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
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(355, 509);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(230, 40);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.AutoResize = false;
            this.txtCategoriaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCategoriaProducto.Depth = 0;
            this.txtCategoriaProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtCategoriaProducto.DropDownHeight = 174;
            this.txtCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoriaProducto.DropDownWidth = 121;
            this.txtCategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCategoriaProducto.FormattingEnabled = true;
            this.txtCategoriaProducto.Hint = "Categoría";
            this.txtCategoriaProducto.IntegralHeight = false;
            this.txtCategoriaProducto.ItemHeight = 43;
            this.txtCategoriaProducto.Location = new System.Drawing.Point(532, 185);
            this.txtCategoriaProducto.MaxDropDownItems = 4;
            this.txtCategoriaProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(322, 49);
            this.txtCategoriaProducto.StartIndex = 0;
            this.txtCategoriaProducto.TabIndex = 13;
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
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Depth = 0;
            this.lblIdProducto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdProducto.Location = new System.Drawing.Point(152, 147);
            this.lblIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(20, 19);
            this.lblIdProducto.TabIndex = 18;
            this.lblIdProducto.Text = "ID:";
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
            // Form_Editar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.txtRutaImg);
            this.Controls.Add(this.txtCategoriaProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompraProducto);
            this.Controls.Add(this.txtCodigoReferenciaProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Editar_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Productos";
            this.Load += new System.EventHandler(this.Form_Editar_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtNombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoReferenciaProducto;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompraProducto;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioVenta;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialComboBox txtCategoriaProducto;
        private MaterialSkin.Controls.MaterialTextBox txtRutaImg;
        private MaterialSkin.Controls.MaterialLabel lblIdProducto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetalles;
    }
}