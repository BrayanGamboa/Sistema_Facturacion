namespace Sistema_Facturacion.Forms.Seguridad
{
    partial class Form_Editar_Rol_Empleado
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
            this.btnActualizarRol = new MaterialSkin.Controls.MaterialButton();
            this.lblIdRol = new MaterialSkin.Controls.MaterialLabel();
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
            this.txtRol.Location = new System.Drawing.Point(292, 282);
            this.txtRol.MaxLength = 50;
            this.txtRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(324, 50);
            this.txtRol.TabIndex = 10;
            this.txtRol.Text = "";
            this.txtRol.TrailingIcon = null;
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.AutoSize = false;
            this.btnActualizarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarRol.Depth = 0;
            this.btnActualizarRol.HighEmphasis = true;
            this.btnActualizarRol.Icon = null;
            this.btnActualizarRol.Location = new System.Drawing.Point(340, 374);
            this.btnActualizarRol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarRol.Size = new System.Drawing.Size(230, 36);
            this.btnActualizarRol.TabIndex = 12;
            this.btnActualizarRol.Text = "Actualizar";
            this.btnActualizarRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarRol.UseAccentColor = false;
            this.btnActualizarRol.UseVisualStyleBackColor = true;
            this.btnActualizarRol.Click += new System.EventHandler(this.btnActualizarRol_Click);
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Depth = 0;
            this.lblIdRol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdRol.Location = new System.Drawing.Point(289, 219);
            this.lblIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(20, 19);
            this.lblIdRol.TabIndex = 13;
            this.lblIdRol.Text = "ID:";
            // 
            // Form_Editar_Rol_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblIdRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.img_salir);
            this.Name = "Form_Editar_Rol_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar roles";
            this.Load += new System.EventHandler(this.Form_Rol_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialTextBox txtRol;
        private MaterialSkin.Controls.MaterialButton btnActualizarRol;
        private MaterialSkin.Controls.MaterialLabel lblIdRol;
    }
}