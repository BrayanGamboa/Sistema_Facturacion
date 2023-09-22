namespace Sistema_Facturacion.Forms.Cliente
{
    partial class Form_Editar_Clientes
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
            this.lbl_id_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nombre_actualizar = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_documento_actualizar = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_telefono_actualizar = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_email_actualizar = new MaterialSkin.Controls.MaterialTextBox();
            this.img_salida = new System.Windows.Forms.PictureBox();
            this.btn_actualizar_usuario = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.img_salida)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_usuario
            // 
            this.lbl_id_usuario.AutoSize = true;
            this.lbl_id_usuario.Depth = 0;
            this.lbl_id_usuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_id_usuario.Location = new System.Drawing.Point(180, 135);
            this.lbl_id_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_id_usuario.Name = "lbl_id_usuario";
            this.lbl_id_usuario.Size = new System.Drawing.Size(24, 19);
            this.lbl_id_usuario.TabIndex = 0;
            this.lbl_id_usuario.Text = "ID: ";
            // 
            // txt_nombre_actualizar
            // 
            this.txt_nombre_actualizar.AnimateReadOnly = false;
            this.txt_nombre_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_actualizar.Depth = 0;
            this.txt_nombre_actualizar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre_actualizar.Hint = "Nombre completo";
            this.txt_nombre_actualizar.LeadingIcon = null;
            this.txt_nombre_actualizar.Location = new System.Drawing.Point(183, 183);
            this.txt_nombre_actualizar.MaxLength = 50;
            this.txt_nombre_actualizar.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre_actualizar.Multiline = false;
            this.txt_nombre_actualizar.Name = "txt_nombre_actualizar";
            this.txt_nombre_actualizar.Size = new System.Drawing.Size(428, 50);
            this.txt_nombre_actualizar.TabIndex = 0;
            this.txt_nombre_actualizar.Text = "";
            this.txt_nombre_actualizar.TrailingIcon = null;
            // 
            // txt_documento_actualizar
            // 
            this.txt_documento_actualizar.AnimateReadOnly = false;
            this.txt_documento_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_documento_actualizar.Depth = 0;
            this.txt_documento_actualizar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_documento_actualizar.Hint = "Documento";
            this.txt_documento_actualizar.LeadingIcon = null;
            this.txt_documento_actualizar.Location = new System.Drawing.Point(183, 251);
            this.txt_documento_actualizar.MaxLength = 50;
            this.txt_documento_actualizar.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_documento_actualizar.Multiline = false;
            this.txt_documento_actualizar.Name = "txt_documento_actualizar";
            this.txt_documento_actualizar.Size = new System.Drawing.Size(428, 50);
            this.txt_documento_actualizar.TabIndex = 1;
            this.txt_documento_actualizar.Text = "";
            this.txt_documento_actualizar.TrailingIcon = null;
            // 
            // txt_telefono_actualizar
            // 
            this.txt_telefono_actualizar.AnimateReadOnly = false;
            this.txt_telefono_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono_actualizar.Depth = 0;
            this.txt_telefono_actualizar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_telefono_actualizar.Hint = "Teléfono";
            this.txt_telefono_actualizar.LeadingIcon = null;
            this.txt_telefono_actualizar.Location = new System.Drawing.Point(183, 323);
            this.txt_telefono_actualizar.MaxLength = 50;
            this.txt_telefono_actualizar.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_telefono_actualizar.Multiline = false;
            this.txt_telefono_actualizar.Name = "txt_telefono_actualizar";
            this.txt_telefono_actualizar.Size = new System.Drawing.Size(428, 50);
            this.txt_telefono_actualizar.TabIndex = 2;
            this.txt_telefono_actualizar.Text = "";
            this.txt_telefono_actualizar.TrailingIcon = null;
            // 
            // txt_email_actualizar
            // 
            this.txt_email_actualizar.AnimateReadOnly = false;
            this.txt_email_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_actualizar.Depth = 0;
            this.txt_email_actualizar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email_actualizar.Hint = "Email";
            this.txt_email_actualizar.LeadingIcon = null;
            this.txt_email_actualizar.Location = new System.Drawing.Point(183, 396);
            this.txt_email_actualizar.MaxLength = 50;
            this.txt_email_actualizar.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email_actualizar.Multiline = false;
            this.txt_email_actualizar.Name = "txt_email_actualizar";
            this.txt_email_actualizar.Size = new System.Drawing.Size(428, 50);
            this.txt_email_actualizar.TabIndex = 3;
            this.txt_email_actualizar.Text = "";
            this.txt_email_actualizar.TrailingIcon = null;
            // 
            // img_salida
            // 
            this.img_salida.Image = global::Sistema_Facturacion.Properties.Resources.casa;
            this.img_salida.Location = new System.Drawing.Point(6, 67);
            this.img_salida.Name = "img_salida";
            this.img_salida.Size = new System.Drawing.Size(100, 87);
            this.img_salida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salida.TabIndex = 4;
            this.img_salida.TabStop = false;
            this.img_salida.Click += new System.EventHandler(this.img_salida_Click);
            // 
            // btn_actualizar_usuario
            // 
            this.btn_actualizar_usuario.AutoSize = false;
            this.btn_actualizar_usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar_usuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar_usuario.Depth = 0;
            this.btn_actualizar_usuario.HighEmphasis = true;
            this.btn_actualizar_usuario.Icon = null;
            this.btn_actualizar_usuario.Location = new System.Drawing.Point(283, 472);
            this.btn_actualizar_usuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar_usuario.Name = "btn_actualizar_usuario";
            this.btn_actualizar_usuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar_usuario.Size = new System.Drawing.Size(230, 40);
            this.btn_actualizar_usuario.TabIndex = 5;
            this.btn_actualizar_usuario.Text = "Actualizar";
            this.btn_actualizar_usuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar_usuario.UseAccentColor = false;
            this.btn_actualizar_usuario.UseVisualStyleBackColor = true;
            this.btn_actualizar_usuario.Click += new System.EventHandler(this.btn_actualizar_usuario_Click);
            // 
            // Form_Editar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 544);
            this.Controls.Add(this.btn_actualizar_usuario);
            this.Controls.Add(this.img_salida);
            this.Controls.Add(this.txt_email_actualizar);
            this.Controls.Add(this.txt_telefono_actualizar);
            this.Controls.Add(this.lbl_id_usuario);
            this.Controls.Add(this.txt_documento_actualizar);
            this.Controls.Add(this.txt_nombre_actualizar);
            this.Name = "Form_Editar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Clientes";
            this.Load += new System.EventHandler(this.Form_Editar_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_id_usuario;
        private MaterialSkin.Controls.MaterialTextBox txt_telefono_actualizar;
        private MaterialSkin.Controls.MaterialTextBox txt_documento_actualizar;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre_actualizar;
        private MaterialSkin.Controls.MaterialTextBox txt_email_actualizar;
        private System.Windows.Forms.PictureBox img_salida;
        private MaterialSkin.Controls.MaterialButton btn_actualizar_usuario;
    }
}