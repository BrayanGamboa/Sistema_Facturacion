namespace Sistema_Facturacion.Forms
{
    partial class Form_Lista_Factura
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
            this.lblFactura = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevaFactura = new MaterialSkin.Controls.MaterialButton();
            this.lstFactura = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarFactura = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarFactura = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Depth = 0;
            this.lblFactura.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFactura.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblFactura.Location = new System.Drawing.Point(239, 9);
            this.lblFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(435, 58);
            this.lblFactura.TabIndex = 15;
            this.lblFactura.Text = "Listado de Facturas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.AutoSize = false;
            this.btnNuevaFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaFactura.Depth = 0;
            this.btnNuevaFactura.HighEmphasis = true;
            this.btnNuevaFactura.Icon = global::Sistema_Facturacion.Properties.Resources.documento_agregar;
            this.btnNuevaFactura.Location = new System.Drawing.Point(328, 474);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevaFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevaFactura.Size = new System.Drawing.Size(230, 40);
            this.btnNuevaFactura.TabIndex = 13;
            this.btnNuevaFactura.Text = "Agregar Factura";
            this.btnNuevaFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevaFactura.UseAccentColor = false;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btn_nuevo_usuario_Click_1);
            // 
            // lstFactura
            // 
            this.lstFactura.BackgroundColor = System.Drawing.Color.White;
            this.lstFactura.ColumnHeadersHeight = 30;
            this.lstFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.dataGridViewTextBoxColumn1,
            this.nombre_empleado,
            this.fecha_compra,
            this.estado_factura,
            this.btnEditar,
            this.btnBorrar});
            this.lstFactura.Location = new System.Drawing.Point(56, 211);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(819, 254);
            this.lstFactura.TabIndex = 12;
            this.lstFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_factura_CellContentClick);
            // 
            // id_factura
            // 
            this.id_factura.HeaderText = "ID Factura";
            this.id_factura.Name = "id_factura";
            this.id_factura.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.HeaderText = "Empleado";
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.Width = 200;
            // 
            // fecha_compra
            // 
            this.fecha_compra.HeaderText = "Fecha compra";
            this.fecha_compra.Name = "fecha_compra";
            // 
            // estado_factura
            // 
            this.estado_factura.HeaderText = "Estado";
            this.estado_factura.Name = "estado_factura";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 50;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.AutoSize = false;
            this.btnBuscarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarFactura.Depth = 0;
            this.btnBuscarFactura.HighEmphasis = true;
            this.btnBuscarFactura.Icon = null;
            this.btnBuscarFactura.Location = new System.Drawing.Point(328, 143);
            this.btnBuscarFactura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarFactura.Size = new System.Drawing.Size(230, 40);
            this.btnBuscarFactura.TabIndex = 11;
            this.btnBuscarFactura.Text = "Buscar";
            this.btnBuscarFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarFactura.UseAccentColor = false;
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.AnimateReadOnly = false;
            this.txtBuscarFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarFactura.Depth = 0;
            this.txtBuscarFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarFactura.Hint = "Ingresa el ID de la factura:";
            this.txtBuscarFactura.LeadingIcon = null;
            this.txtBuscarFactura.Location = new System.Drawing.Point(249, 84);
            this.txtBuscarFactura.MaxLength = 50;
            this.txtBuscarFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarFactura.Multiline = false;
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.Size = new System.Drawing.Size(425, 50);
            this.txtBuscarFactura.TabIndex = 10;
            this.txtBuscarFactura.Text = "";
            this.txtBuscarFactura.TrailingIcon = null;
            // 
            // Form_Lista_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 544);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.lstFactura);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.txtBuscarFactura);
            this.Name = "Form_Lista_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Lista_Factura";
            this.Load += new System.EventHandler(this.Form_Lista_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnNuevaFactura;
        private System.Windows.Forms.DataGridView lstFactura;
        private MaterialSkin.Controls.MaterialButton btnBuscarFactura;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_factura;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}