namespace Sistema_Facturacion.Forms.Facturacion.CRUD_Factura
{
    partial class Form_Factura_Nuevo
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
            this.btnNuevaFactura = new MaterialSkin.Controls.MaterialButton();
            this.txtDetalles = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIva = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialComboBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.valorTotal = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.AutoSize = false;
            this.btnNuevaFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaFactura.Depth = 0;
            this.btnNuevaFactura.HighEmphasis = true;
            this.btnNuevaFactura.Icon = null;
            this.btnNuevaFactura.Location = new System.Drawing.Point(352, 481);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevaFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevaFactura.Size = new System.Drawing.Size(230, 36);
            this.btnNuevaFactura.TabIndex = 31;
            this.btnNuevaFactura.Text = "Nuevo";
            this.btnNuevaFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevaFactura.UseAccentColor = false;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.AnimateReadOnly = false;
            this.txtDetalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDetalles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetalles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalles.Depth = 0;
            this.txtDetalles.HideSelection = true;
            this.txtDetalles.Hint = "Observaciones o detalles:";
            this.txtDetalles.Location = new System.Drawing.Point(491, 253);
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
            this.txtDetalles.Size = new System.Drawing.Size(297, 171);
            this.txtDetalles.TabIndex = 30;
            this.txtDetalles.TabStop = false;
            this.txtDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetalles.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(488, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(127, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Fecha de compra:";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoResize = false;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEstado.Depth = 0;
            this.txtEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtEstado.DropDownHeight = 174;
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.DropDownWidth = 121;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Hint = "Estado Factura";
            this.txtEstado.IntegralHeight = false;
            this.txtEstado.ItemHeight = 43;
            this.txtEstado.Location = new System.Drawing.Point(488, 193);
            this.txtEstado.MaxDropDownItems = 4;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(300, 49);
            this.txtEstado.StartIndex = 0;
            this.txtEstado.TabIndex = 27;
            // 
            // fechaFactura
            // 
            this.fechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFactura.Location = new System.Drawing.Point(488, 162);
            this.fechaFactura.Margin = new System.Windows.Forms.Padding(5);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(300, 20);
            this.fechaFactura.TabIndex = 26;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(154, 251);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(300, 50);
            this.txtDescuento.TabIndex = 25;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            // 
            // txtIva
            // 
            this.txtIva.AnimateReadOnly = false;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIva.Depth = 0;
            this.txtIva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIva.Hint = "Total Iva";
            this.txtIva.LeadingIcon = null;
            this.txtIva.Location = new System.Drawing.Point(154, 312);
            this.txtIva.MaxLength = 50;
            this.txtIva.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIva.Multiline = false;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(300, 50);
            this.txtIva.TabIndex = 24;
            this.txtIva.Text = "";
            this.txtIva.TrailingIcon = null;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AutoResize = false;
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtNombreEmpleado.DropDownHeight = 174;
            this.txtNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNombreEmpleado.DropDownWidth = 121;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreEmpleado.FormattingEnabled = true;
            this.txtNombreEmpleado.Hint = "Empleado";
            this.txtNombreEmpleado.IntegralHeight = false;
            this.txtNombreEmpleado.ItemHeight = 43;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(154, 191);
            this.txtNombreEmpleado.MaxDropDownItems = 4;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(300, 49);
            this.txtNombreEmpleado.StartIndex = 0;
            this.txtNombreEmpleado.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AutoResize = false;
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtNombreCliente.DropDownHeight = 174;
            this.txtNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNombreCliente.DropDownWidth = 121;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreCliente.FormattingEnabled = true;
            this.txtNombreCliente.Hint = "Cliente";
            this.txtNombreCliente.IntegralHeight = false;
            this.txtNombreCliente.ItemHeight = 43;
            this.txtNombreCliente.Location = new System.Drawing.Point(154, 131);
            this.txtNombreCliente.MaxDropDownItems = 4;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(300, 49);
            this.txtNombreCliente.StartIndex = 0;
            this.txtNombreCliente.TabIndex = 22;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(6, 67);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 20;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // valorTotal
            // 
            this.valorTotal.AnimateReadOnly = false;
            this.valorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorTotal.Depth = 0;
            this.valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.valorTotal.Hint = "Valor de factura";
            this.valorTotal.LeadingIcon = null;
            this.valorTotal.Location = new System.Drawing.Point(154, 372);
            this.valorTotal.MaxLength = 50;
            this.valorTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.valorTotal.Multiline = false;
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(300, 50);
            this.valorTotal.TabIndex = 32;
            this.valorTotal.Text = "";
            this.valorTotal.TrailingIcon = null;
            // 
            // Form_Factura_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 544);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Factura_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Factura";
            this.Load += new System.EventHandler(this.Form_Factura_Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnNuevaFactura;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetalles;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox txtEstado;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtIva;
        private MaterialSkin.Controls.MaterialComboBox txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialComboBox txtNombreCliente;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox valorTotal;
    }
}