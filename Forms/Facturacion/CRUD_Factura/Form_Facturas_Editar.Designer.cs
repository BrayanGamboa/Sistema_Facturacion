namespace Sistema_Facturacion.Forms
{
    partial class Form_Facturas_Editar
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
            this.txtIdFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIva = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.lblValorTotal = new MaterialSkin.Controls.MaterialLabel();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnActualizarFactura = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(6, 67);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 7;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.AnimateReadOnly = false;
            this.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFactura.Depth = 0;
            this.txtIdFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdFactura.Hint = "Número de factura";
            this.txtIdFactura.LeadingIcon = null;
            this.txtIdFactura.Location = new System.Drawing.Point(157, 125);
            this.txtIdFactura.MaxLength = 50;
            this.txtIdFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdFactura.Multiline = false;
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(300, 50);
            this.txtIdFactura.TabIndex = 8;
            this.txtIdFactura.Text = "";
            this.txtIdFactura.TrailingIcon = null;
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
            this.txtNombreCliente.Location = new System.Drawing.Point(157, 186);
            this.txtNombreCliente.MaxDropDownItems = 4;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(300, 49);
            this.txtNombreCliente.StartIndex = 0;
            this.txtNombreCliente.TabIndex = 9;
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
            this.txtNombreEmpleado.Location = new System.Drawing.Point(157, 246);
            this.txtNombreEmpleado.MaxDropDownItems = 4;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(300, 49);
            this.txtNombreEmpleado.StartIndex = 0;
            this.txtNombreEmpleado.TabIndex = 10;
            // 
            // txtIva
            // 
            this.txtIva.AnimateReadOnly = false;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIva.Depth = 0;
            this.txtIva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIva.Hint = "Total Iva";
            this.txtIva.LeadingIcon = null;
            this.txtIva.Location = new System.Drawing.Point(157, 367);
            this.txtIva.MaxLength = 50;
            this.txtIva.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIva.Multiline = false;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(300, 50);
            this.txtIva.TabIndex = 11;
            this.txtIva.Text = "";
            this.txtIva.TrailingIcon = null;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(157, 306);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(300, 50);
            this.txtDescuento.TabIndex = 12;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Depth = 0;
            this.lblValorTotal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblValorTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblValorTotal.Location = new System.Drawing.Point(153, 429);
            this.lblValorTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(140, 24);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "Total a pagar: $";
            // 
            // fechaFactura
            // 
            this.fechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFactura.Location = new System.Drawing.Point(491, 155);
            this.fechaFactura.Margin = new System.Windows.Forms.Padding(5);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(300, 20);
            this.fechaFactura.TabIndex = 14;
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
            this.txtEstado.Location = new System.Drawing.Point(491, 186);
            this.txtEstado.MaxDropDownItems = 4;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(300, 49);
            this.txtEstado.StartIndex = 0;
            this.txtEstado.TabIndex = 15;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(491, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(127, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Fecha de compra:";
            // 
            // materialMultiLineTextBox21
            // 
            this.materialMultiLineTextBox21.AnimateReadOnly = false;
            this.materialMultiLineTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialMultiLineTextBox21.Depth = 0;
            this.materialMultiLineTextBox21.HideSelection = true;
            this.materialMultiLineTextBox21.Hint = "Observaciones o detalles:";
            this.materialMultiLineTextBox21.Location = new System.Drawing.Point(494, 246);
            this.materialMultiLineTextBox21.MaxLength = 32767;
            this.materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            this.materialMultiLineTextBox21.PasswordChar = '\0';
            this.materialMultiLineTextBox21.ReadOnly = false;
            this.materialMultiLineTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBox21.SelectedText = "";
            this.materialMultiLineTextBox21.SelectionLength = 0;
            this.materialMultiLineTextBox21.SelectionStart = 0;
            this.materialMultiLineTextBox21.ShortcutsEnabled = true;
            this.materialMultiLineTextBox21.Size = new System.Drawing.Size(297, 171);
            this.materialMultiLineTextBox21.TabIndex = 18;
            this.materialMultiLineTextBox21.TabStop = false;
            this.materialMultiLineTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // btnActualizarFactura
            // 
            this.btnActualizarFactura.AutoSize = false;
            this.btnActualizarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarFactura.Depth = 0;
            this.btnActualizarFactura.HighEmphasis = true;
            this.btnActualizarFactura.Icon = null;
            this.btnActualizarFactura.Location = new System.Drawing.Point(353, 473);
            this.btnActualizarFactura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarFactura.Name = "btnActualizarFactura";
            this.btnActualizarFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarFactura.Size = new System.Drawing.Size(230, 40);
            this.btnActualizarFactura.TabIndex = 19;
            this.btnActualizarFactura.Text = "Actualizar";
            this.btnActualizarFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarFactura.UseAccentColor = false;
            this.btnActualizarFactura.UseVisualStyleBackColor = true;
            // 
            // Form_Facturas_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 544);
            this.Controls.Add(this.btnActualizarFactura);
            this.Controls.Add(this.materialMultiLineTextBox21);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Facturas_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actutualizar Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtIdFactura;
        private MaterialSkin.Controls.MaterialComboBox txtNombreCliente;
        private MaterialSkin.Controls.MaterialComboBox txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtIva;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialLabel lblValorTotal;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private MaterialSkin.Controls.MaterialComboBox txtEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialButton btnActualizarFactura;
    }
}