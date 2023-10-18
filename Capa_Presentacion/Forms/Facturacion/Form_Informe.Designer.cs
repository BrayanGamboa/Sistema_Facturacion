namespace Sistema_Facturacion.Forms.Facturacion
{
    partial class Form_Informe
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
            this.txtSeleccionarInforme = new MaterialSkin.Controls.MaterialComboBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.txtOrdenar = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerar = new MaterialSkin.Controls.MaterialButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeleccionarInforme
            // 
            this.txtSeleccionarInforme.AutoResize = false;
            this.txtSeleccionarInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSeleccionarInforme.Depth = 0;
            this.txtSeleccionarInforme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtSeleccionarInforme.DropDownHeight = 174;
            this.txtSeleccionarInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSeleccionarInforme.DropDownWidth = 121;
            this.txtSeleccionarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeleccionarInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSeleccionarInforme.FormattingEnabled = true;
            this.txtSeleccionarInforme.Hint = "Seleccionar Informe";
            this.txtSeleccionarInforme.IntegralHeight = false;
            this.txtSeleccionarInforme.ItemHeight = 43;
            this.txtSeleccionarInforme.Location = new System.Drawing.Point(328, 117);
            this.txtSeleccionarInforme.MaxDropDownItems = 4;
            this.txtSeleccionarInforme.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSeleccionarInforme.Name = "txtSeleccionarInforme";
            this.txtSeleccionarInforme.Size = new System.Drawing.Size(270, 49);
            this.txtSeleccionarInforme.StartIndex = 0;
            this.txtSeleccionarInforme.TabIndex = 0;
            // 
            // img_salir
            // 
            this.img_salir.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salir.Location = new System.Drawing.Point(12, 12);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(100, 99);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 8;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // txtOrdenar
            // 
            this.txtOrdenar.AutoResize = false;
            this.txtOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrdenar.Depth = 0;
            this.txtOrdenar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtOrdenar.DropDownHeight = 174;
            this.txtOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtOrdenar.DropDownWidth = 121;
            this.txtOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrdenar.FormattingEnabled = true;
            this.txtOrdenar.Hint = "Ordenar por";
            this.txtOrdenar.IntegralHeight = false;
            this.txtOrdenar.ItemHeight = 43;
            this.txtOrdenar.Location = new System.Drawing.Point(328, 196);
            this.txtOrdenar.MaxDropDownItems = 4;
            this.txtOrdenar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOrdenar.Name = "txtOrdenar";
            this.txtOrdenar.Size = new System.Drawing.Size(270, 49);
            this.txtOrdenar.StartIndex = 0;
            this.txtOrdenar.TabIndex = 9;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaInicio.Location = new System.Drawing.Point(328, 264);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(111, 19);
            this.lblFechaInicio.TabIndex = 18;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // fechaFactura
            // 
            this.fechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFactura.Location = new System.Drawing.Point(328, 294);
            this.fechaFactura.Margin = new System.Windows.Forms.Padding(5);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(270, 20);
            this.fechaFactura.TabIndex = 17;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaFinal.Location = new System.Drawing.Point(328, 330);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(87, 19);
            this.lblFechaFinal.TabIndex = 20;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 360);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // btnPdf
            // 
            this.btnPdf.AutoSize = true;
            this.btnPdf.Depth = 0;
            this.btnPdf.Location = new System.Drawing.Point(257, 411);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(0);
            this.btnPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Ripple = true;
            this.btnPdf.Size = new System.Drawing.Size(65, 37);
            this.btnPdf.TabIndex = 21;
            this.btnPdf.TabStop = true;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(597, 411);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(72, 37);
            this.materialRadioButton2.TabIndex = 22;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Excel";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // btnPantalla
            // 
            this.btnPantalla.AutoSize = true;
            this.btnPantalla.Depth = 0;
            this.btnPantalla.Location = new System.Drawing.Point(397, 410);
            this.btnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.btnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Ripple = true;
            this.btnPantalla.Size = new System.Drawing.Size(116, 37);
            this.btnPantalla.TabIndex = 23;
            this.btnPantalla.TabStop = true;
            this.btnPantalla.Text = "En Pantalla";
            this.btnPantalla.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = false;
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerar.Depth = 0;
            this.btnGenerar.HighEmphasis = true;
            this.btnGenerar.Icon = null;
            this.btnGenerar.Location = new System.Drawing.Point(341, 484);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerar.Size = new System.Drawing.Size(230, 40);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerar.UseAccentColor = false;
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(282, 30);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 58);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Generar Informe:";
            // 
            // Form_Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnPantalla);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.txtOrdenar);
            this.Controls.Add(this.img_salir);
            this.Controls.Add(this.txtSeleccionarInforme);
            this.Name = "Form_Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar informe";
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox txtSeleccionarInforme;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialComboBox txtOrdenar;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialRadioButton btnPdf;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton btnPantalla;
        private MaterialSkin.Controls.MaterialButton btnGenerar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}