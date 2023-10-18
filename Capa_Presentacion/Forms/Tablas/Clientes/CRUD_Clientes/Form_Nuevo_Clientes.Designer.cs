namespace Sistema_Facturacion.Forms.Tablas.CRUD_Clientes
{
    partial class Form_Nuevo_Clientes
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
            this.btn_nuevo_usuario = new MaterialSkin.Controls.MaterialButton();
            this.img_salida = new System.Windows.Forms.PictureBox();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_telefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_documento = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_salida)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevo_usuario
            // 
            this.btn_nuevo_usuario.AutoSize = false;
            this.btn_nuevo_usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo_usuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_nuevo_usuario.Depth = 0;
            this.btn_nuevo_usuario.HighEmphasis = true;
            this.btn_nuevo_usuario.Icon = null;
            this.btn_nuevo_usuario.Location = new System.Drawing.Point(283, 472);
            this.btn_nuevo_usuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_nuevo_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_nuevo_usuario.Name = "btn_nuevo_usuario";
            this.btn_nuevo_usuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_nuevo_usuario.Size = new System.Drawing.Size(230, 40);
            this.btn_nuevo_usuario.TabIndex = 12;
            this.btn_nuevo_usuario.Text = "Crear";
            this.btn_nuevo_usuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_nuevo_usuario.UseAccentColor = false;
            this.btn_nuevo_usuario.UseVisualStyleBackColor = true;
            this.btn_nuevo_usuario.Click += new System.EventHandler(this.btn_nuevo_nuevo_Click);
            // 
            // img_salida
            // 
            this.img_salida.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salida.Location = new System.Drawing.Point(6, 67);
            this.img_salida.Name = "img_salida";
            this.img_salida.Size = new System.Drawing.Size(100, 87);
            this.img_salida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salida.TabIndex = 11;
            this.img_salida.TabStop = false;
            this.img_salida.Click += new System.EventHandler(this.img_salida_Click);
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(183, 396);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(428, 50);
            this.txt_email.TabIndex = 10;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            // 
            // txt_telefono
            // 
            this.txt_telefono.AnimateReadOnly = false;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Depth = 0;
            this.txt_telefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_telefono.Hint = "Teléfono";
            this.txt_telefono.LeadingIcon = null;
            this.txt_telefono.Location = new System.Drawing.Point(183, 323);
            this.txt_telefono.MaxLength = 50;
            this.txt_telefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_telefono.Multiline = false;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(428, 50);
            this.txt_telefono.TabIndex = 9;
            this.txt_telefono.Text = "";
            this.txt_telefono.TrailingIcon = null;
            // 
            // txt_documento
            // 
            this.txt_documento.AnimateReadOnly = false;
            this.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_documento.Depth = 0;
            this.txt_documento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_documento.Hint = "Documento";
            this.txt_documento.LeadingIcon = null;
            this.txt_documento.Location = new System.Drawing.Point(183, 251);
            this.txt_documento.MaxLength = 50;
            this.txt_documento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_documento.Multiline = false;
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(428, 50);
            this.txt_documento.TabIndex = 8;
            this.txt_documento.Text = "";
            this.txt_documento.TrailingIcon = null;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.Hint = "Nombre completo";
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(183, 183);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(428, 50);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.Text = "";
            this.txt_nombre.TrailingIcon = null;
            // 
            // Form_Nuevo_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 544);
            this.Controls.Add(this.btn_nuevo_usuario);
            this.Controls.Add(this.img_salida);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_Nuevo_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.img_salida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_nuevo_usuario;
        private System.Windows.Forms.PictureBox img_salida;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private MaterialSkin.Controls.MaterialTextBox txt_telefono;
        private MaterialSkin.Controls.MaterialTextBox txt_documento;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
    }
}