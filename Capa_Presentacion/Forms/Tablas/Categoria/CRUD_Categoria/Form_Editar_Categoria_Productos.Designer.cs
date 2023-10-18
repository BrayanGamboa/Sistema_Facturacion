namespace Sistema_Facturacion.Forms
{
    partial class Form_Editar_Categoria_Productos
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
            this.txtCategoria = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.btnEditarCategoria = new MaterialSkin.Controls.MaterialButton();
            this.lblIdCategoria = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.AllowPromptAsInput = true;
            this.txtCategoria.AnimateReadOnly = false;
            this.txtCategoria.AsciiOnly = false;
            this.txtCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCategoria.BeepOnError = false;
            this.txtCategoria.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategoria.HidePromptOnLeave = false;
            this.txtCategoria.HideSelection = true;
            this.txtCategoria.Hint = "Nombre de la categoría";
            this.txtCategoria.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCategoria.LeadingIcon = null;
            this.txtCategoria.Location = new System.Drawing.Point(277, 269);
            this.txtCategoria.Mask = "";
            this.txtCategoria.MaxLength = 32767;
            this.txtCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.PrefixSuffixText = null;
            this.txtCategoria.PromptChar = '_';
            this.txtCategoria.ReadOnly = false;
            this.txtCategoria.RejectInputOnFirstFailure = false;
            this.txtCategoria.ResetOnPrompt = true;
            this.txtCategoria.ResetOnSpace = true;
            this.txtCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.ShortcutsEnabled = true;
            this.txtCategoria.Size = new System.Drawing.Size(348, 48);
            this.txtCategoria.SkipLiterals = true;
            this.txtCategoria.TabIndex = 0;
            this.txtCategoria.TabStop = false;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoria.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCategoria.TrailingIcon = null;
            this.txtCategoria.UseSystemPasswordChar = false;
            this.txtCategoria.ValidatingType = null;
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
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.AutoSize = false;
            this.btnEditarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCategoria.Depth = 0;
            this.btnEditarCategoria.HighEmphasis = true;
            this.btnEditarCategoria.Icon = null;
            this.btnEditarCategoria.Location = new System.Drawing.Point(333, 378);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCategoria.Size = new System.Drawing.Size(230, 40);
            this.btnEditarCategoria.TabIndex = 8;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCategoria.UseAccentColor = false;
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Depth = 0;
            this.lblIdCategoria.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdCategoria.Location = new System.Drawing.Point(274, 177);
            this.lblIdCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(20, 19);
            this.lblIdCategoria.TabIndex = 9;
            this.lblIdCategoria.Text = "ID:";
            // 
            // Form_Editar_Categoria_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.img_salir);
            this.Controls.Add(this.txtCategoria);
            this.Name = "Form_Editar_Categoria_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Categoría";
            this.Load += new System.EventHandler(this.Form_Editar_Categoria_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtCategoria;
        private System.Windows.Forms.PictureBox img_salir;
        private MaterialSkin.Controls.MaterialButton btnEditarCategoria;
        private MaterialSkin.Controls.MaterialLabel lblIdCategoria;
    }
}