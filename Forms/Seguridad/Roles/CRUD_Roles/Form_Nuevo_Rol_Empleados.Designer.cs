namespace Sistema_Facturacion.Forms.Seguridad
{
    partial class Form_Nuevo_Rol_Empleados
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
            this.txtRol = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCrearRol = new MaterialSkin.Controls.MaterialButton();
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
            this.img_salir.TabIndex = 9;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // txtRol
            // 
            this.txtRol.AnimateReadOnly = false;
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRol.Depth = 0;
            this.txtRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRol.Hint = "Nombre del rol";
            this.txtRol.LeadingIcon = null;
            this.txtRol.Location = new System.Drawing.Point(296, 286);
            this.txtRol.MaxLength = 50;
            this.txtRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(324, 50);
            this.txtRol.TabIndex = 10;
            this.txtRol.Text = "";
            this.txtRol.TrailingIcon = null;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.AutoSize = false;
            this.btnCrearRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearRol.Depth = 0;
            this.btnCrearRol.HighEmphasis = true;
            this.btnCrearRol.Icon = null;
            this.btnCrearRol.Location = new System.Drawing.Point(334, 380);
            this.btnCrearRol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearRol.Size = new System.Drawing.Size(230, 36);
            this.btnCrearRol.TabIndex = 12;
            this.btnCrearRol.Text = "Crear";
            this.btnCrearRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearRol.UseAccentColor = false;
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // Form_Nuevo_Rol_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Nuevo_Rol_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtRol;
        private MaterialSkin.Controls.MaterialButton btnCrearRol;
    }
}