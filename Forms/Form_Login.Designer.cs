namespace Sistema_Facturacion
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.txtPasswordLogin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsuarioLogin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnSendLogin = new MaterialSkin.Controls.MaterialButton();
            this.panelLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogin
            // 
            this.imgLogin.Image = global::Sistema_Facturacion.Properties.Resources.user;
            this.imgLogin.Location = new System.Drawing.Point(320, 28);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(102, 102);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogin.TabIndex = 1;
            this.imgLogin.TabStop = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.AllowPromptAsInput = true;
            this.txtPasswordLogin.AnimateReadOnly = false;
            this.txtPasswordLogin.AsciiOnly = false;
            this.txtPasswordLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPasswordLogin.BeepOnError = false;
            this.txtPasswordLogin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPasswordLogin.Depth = 0;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordLogin.HidePromptOnLeave = false;
            this.txtPasswordLogin.HideSelection = true;
            this.txtPasswordLogin.Hint = "Password";
            this.txtPasswordLogin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPasswordLogin.LeadingIcon = global::Sistema_Facturacion.Properties.Resources.contrasena;
            this.txtPasswordLogin.Location = new System.Drawing.Point(26, 140);
            this.txtPasswordLogin.Mask = "";
            this.txtPasswordLogin.MaxLength = 32767;
            this.txtPasswordLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '●';
            this.txtPasswordLogin.PrefixSuffixText = null;
            this.txtPasswordLogin.PromptChar = '_';
            this.txtPasswordLogin.ReadOnly = false;
            this.txtPasswordLogin.RejectInputOnFirstFailure = false;
            this.txtPasswordLogin.ResetOnPrompt = true;
            this.txtPasswordLogin.ResetOnSpace = true;
            this.txtPasswordLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPasswordLogin.SelectedText = "";
            this.txtPasswordLogin.SelectionLength = 0;
            this.txtPasswordLogin.SelectionStart = 0;
            this.txtPasswordLogin.ShortcutsEnabled = true;
            this.txtPasswordLogin.Size = new System.Drawing.Size(250, 48);
            this.txtPasswordLogin.SkipLiterals = true;
            this.txtPasswordLogin.TabIndex = 1;
            this.txtPasswordLogin.TabStop = false;
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordLogin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPasswordLogin.TrailingIcon = null;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            this.txtPasswordLogin.ValidatingType = null;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.AllowPromptAsInput = true;
            this.txtUsuarioLogin.AnimateReadOnly = false;
            this.txtUsuarioLogin.AsciiOnly = false;
            this.txtUsuarioLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuarioLogin.BeepOnError = false;
            this.txtUsuarioLogin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsuarioLogin.Depth = 0;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioLogin.HidePromptOnLeave = false;
            this.txtUsuarioLogin.HideSelection = true;
            this.txtUsuarioLogin.Hint = "Usuario";
            this.txtUsuarioLogin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsuarioLogin.LeadingIcon = global::Sistema_Facturacion.Properties.Resources.correo_electronico_;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(26, 67);
            this.txtUsuarioLogin.Mask = "";
            this.txtUsuarioLogin.MaxLength = 32767;
            this.txtUsuarioLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.PasswordChar = '\0';
            this.txtUsuarioLogin.PrefixSuffixText = null;
            this.txtUsuarioLogin.PromptChar = '_';
            this.txtUsuarioLogin.ReadOnly = false;
            this.txtUsuarioLogin.RejectInputOnFirstFailure = false;
            this.txtUsuarioLogin.ResetOnPrompt = true;
            this.txtUsuarioLogin.ResetOnSpace = true;
            this.txtUsuarioLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioLogin.SelectedText = "";
            this.txtUsuarioLogin.SelectionLength = 0;
            this.txtUsuarioLogin.SelectionStart = 0;
            this.txtUsuarioLogin.ShortcutsEnabled = true;
            this.txtUsuarioLogin.Size = new System.Drawing.Size(250, 48);
            this.txtUsuarioLogin.SkipLiterals = true;
            this.txtUsuarioLogin.TabIndex = 2;
            this.txtUsuarioLogin.TabStop = false;
            this.txtUsuarioLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuarioLogin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsuarioLogin.TrailingIcon = null;
            this.txtUsuarioLogin.UseSystemPasswordChar = false;
            this.txtUsuarioLogin.ValidatingType = null;
            // 
            // btnSendLogin
            // 
            this.btnSendLogin.AutoSize = false;
            this.btnSendLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSendLogin.Depth = 0;
            this.btnSendLogin.HighEmphasis = true;
            this.btnSendLogin.Icon = null;
            this.btnSendLogin.Location = new System.Drawing.Point(74, 212);
            this.btnSendLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendLogin.Name = "btnSendLogin";
            this.btnSendLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSendLogin.Size = new System.Drawing.Size(158, 36);
            this.btnSendLogin.TabIndex = 3;
            this.btnSendLogin.Text = "Iniciar";
            this.btnSendLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendLogin.UseAccentColor = false;
            this.btnSendLogin.UseVisualStyleBackColor = true;
            this.btnSendLogin.Click += new System.EventHandler(this.btn_send_login_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnSendLogin);
            this.panelLogin.Controls.Add(this.txtUsuarioLogin);
            this.panelLogin.Controls.Add(this.txtPasswordLogin);
            this.panelLogin.Location = new System.Drawing.Point(219, 101);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 266);
            this.panelLogin.TabIndex = 0;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Facturacion.Properties.Resources.Captura_de_pantalla_2023_08_14_214010;
            this.ClientSize = new System.Drawing.Size(734, 446);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPasswordLogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsuarioLogin;
        private MaterialSkin.Controls.MaterialButton btnSendLogin;
        private System.Windows.Forms.Panel panelLogin;
    }
}

