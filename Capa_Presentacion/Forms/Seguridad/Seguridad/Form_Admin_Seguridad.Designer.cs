namespace Sistema_Facturacion.Forms.Seguridad
{
    partial class Form_Admin_Seguridad
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
            this.listEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActualizarCredenciales = new MaterialSkin.Controls.MaterialButton();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.btnEliminarCredenciales = new MaterialSkin.Controls.MaterialButton();
            this.btnConsultarCredenciales = new MaterialSkin.Controls.MaterialButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // listEmpleado
            // 
            this.listEmpleado.AutoResize = false;
            this.listEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEmpleado.Depth = 0;
            this.listEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listEmpleado.DropDownHeight = 174;
            this.listEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listEmpleado.DropDownWidth = 121;
            this.listEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.listEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listEmpleado.FormattingEnabled = true;
            this.listEmpleado.Hint = "Empleado";
            this.listEmpleado.IntegralHeight = false;
            this.listEmpleado.ItemHeight = 43;
            this.listEmpleado.Location = new System.Drawing.Point(289, 146);
            this.listEmpleado.MaxDropDownItems = 4;
            this.listEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.listEmpleado.Name = "listEmpleado";
            this.listEmpleado.Size = new System.Drawing.Size(354, 49);
            this.listEmpleado.StartIndex = 0;
            this.listEmpleado.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(289, 219);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(354, 50);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AnimateReadOnly = false;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.Hint = "Contraseña";
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(289, 302);
            this.txtContrasena.MaxLength = 50;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(354, 50);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.Text = "";
            this.txtContrasena.TrailingIcon = null;
            // 
            // btnActualizarCredenciales
            // 
            this.btnActualizarCredenciales.AutoSize = false;
            this.btnActualizarCredenciales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCredenciales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarCredenciales.Depth = 0;
            this.btnActualizarCredenciales.HighEmphasis = true;
            this.btnActualizarCredenciales.Icon = null;
            this.btnActualizarCredenciales.Location = new System.Drawing.Point(340, 408);
            this.btnActualizarCredenciales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCredenciales.Name = "btnActualizarCredenciales";
            this.btnActualizarCredenciales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarCredenciales.Size = new System.Drawing.Size(230, 36);
            this.btnActualizarCredenciales.TabIndex = 3;
            this.btnActualizarCredenciales.Text = "Actualizar";
            this.btnActualizarCredenciales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarCredenciales.UseAccentColor = false;
            this.btnActualizarCredenciales.UseVisualStyleBackColor = true;
            this.btnActualizarCredenciales.Click += new System.EventHandler(this.btnActualizarCredenciales_Click);
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
            // btnEliminarCredenciales
            // 
            this.btnEliminarCredenciales.AutoSize = false;
            this.btnEliminarCredenciales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCredenciales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCredenciales.Depth = 0;
            this.btnEliminarCredenciales.HighEmphasis = true;
            this.btnEliminarCredenciales.Icon = null;
            this.btnEliminarCredenciales.Location = new System.Drawing.Point(595, 408);
            this.btnEliminarCredenciales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCredenciales.Name = "btnEliminarCredenciales";
            this.btnEliminarCredenciales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarCredenciales.Size = new System.Drawing.Size(230, 36);
            this.btnEliminarCredenciales.TabIndex = 9;
            this.btnEliminarCredenciales.Text = "Eliminar";
            this.btnEliminarCredenciales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCredenciales.UseAccentColor = false;
            this.btnEliminarCredenciales.UseVisualStyleBackColor = true;
            this.btnEliminarCredenciales.Click += new System.EventHandler(this.btnEliminarCredenciales_Click);
            // 
            // btnConsultarCredenciales
            // 
            this.btnConsultarCredenciales.AutoSize = false;
            this.btnConsultarCredenciales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarCredenciales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultarCredenciales.Depth = 0;
            this.btnConsultarCredenciales.HighEmphasis = true;
            this.btnConsultarCredenciales.Icon = null;
            this.btnConsultarCredenciales.Location = new System.Drawing.Point(75, 408);
            this.btnConsultarCredenciales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultarCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarCredenciales.Name = "btnConsultarCredenciales";
            this.btnConsultarCredenciales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultarCredenciales.Size = new System.Drawing.Size(230, 36);
            this.btnConsultarCredenciales.TabIndex = 10;
            this.btnConsultarCredenciales.Text = "Consultar";
            this.btnConsultarCredenciales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultarCredenciales.UseAccentColor = false;
            this.btnConsultarCredenciales.UseVisualStyleBackColor = true;
            this.btnConsultarCredenciales.Click += new System.EventHandler(this.btnConsultarCredenciales_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblTitulo.Location = new System.Drawing.Point(148, 34);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(687, 58);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Administración de Credenciales:";
            // 
            // Form_Admin_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 537);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConsultarCredenciales);
            this.Controls.Add(this.btnEliminarCredenciales);
            this.Controls.Add(this.img_salir);
            this.Controls.Add(this.btnActualizarCredenciales);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.listEmpleado);
            this.Name = "Form_Admin_Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de usuarios del sistema";
            this.Load += new System.EventHandler(this.Form_Admin_Seguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox listEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContrasena;
        private MaterialSkin.Controls.MaterialButton btnActualizarCredenciales;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialButton btnEliminarCredenciales;
        private MaterialSkin.Controls.MaterialButton btnConsultarCredenciales;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}