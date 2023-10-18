namespace Sistema_Facturacion
{
    partial class Form_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            this.Panel_Principal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Panel_Navegacion = new System.Windows.Forms.Panel();
            this.menuNavegacion = new MaterialSkin.Controls.MaterialTabControl();
            this.Tab_Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.imgLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.Tab_Tablas = new System.Windows.Forms.TabPage();
            this.imgLogoTablas = new System.Windows.Forms.PictureBox();
            this.btnProductos = new MaterialSkin.Controls.MaterialButton();
            this.btnCategoria = new MaterialSkin.Controls.MaterialButton();
            this.btnClientes = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Facturacion = new System.Windows.Forms.TabPage();
            this.ImgLogoFacturacion = new System.Windows.Forms.PictureBox();
            this.btnInforme = new MaterialSkin.Controls.MaterialButton();
            this.btnFactura = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Seguridad = new System.Windows.Forms.TabPage();
            this.btnSeguridad = new MaterialSkin.Controls.MaterialButton();
            this.imgLogoSeguridad = new System.Windows.Forms.PictureBox();
            this.btnRoles = new MaterialSkin.Controls.MaterialButton();
            this.btnEmpleados = new MaterialSkin.Controls.MaterialButton();
            this.Tab_Info = new System.Windows.Forms.TabPage();
            this.imgLogoInformacion = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new MaterialSkin.Controls.MaterialButton();
            this.btnInformacion = new MaterialSkin.Controls.MaterialButton();
            this.TabOpcInicio = new MaterialSkin.Controls.MaterialTabSelector();
            this.Panel_Principal.SuspendLayout();
            this.Panel_Navegacion.SuspendLayout();
            this.menuNavegacion.SuspendLayout();
            this.Tab_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoPrincipal)).BeginInit();
            this.Tab_Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTablas)).BeginInit();
            this.Tab_Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoFacturacion)).BeginInit();
            this.Tab_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSeguridad)).BeginInit();
            this.Tab_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Principal
            // 
            this.Panel_Principal.Controls.Add(this.panelContenedor);
            this.Panel_Principal.Controls.Add(this.Panel_Navegacion);
            this.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Principal.Location = new System.Drawing.Point(3, 64);
            this.Panel_Principal.Name = "Panel_Principal";
            this.Panel_Principal.Size = new System.Drawing.Size(1194, 583);
            this.Panel_Principal.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(270, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(924, 583);
            this.panelContenedor.TabIndex = 1;
            // 
            // Panel_Navegacion
            // 
            this.Panel_Navegacion.BackColor = System.Drawing.Color.White;
            this.Panel_Navegacion.Controls.Add(this.menuNavegacion);
            this.Panel_Navegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Navegacion.Location = new System.Drawing.Point(0, 0);
            this.Panel_Navegacion.Name = "Panel_Navegacion";
            this.Panel_Navegacion.Size = new System.Drawing.Size(270, 583);
            this.Panel_Navegacion.TabIndex = 0;
            // 
            // menuNavegacion
            // 
            this.menuNavegacion.Controls.Add(this.Tab_Principal);
            this.menuNavegacion.Controls.Add(this.Tab_Tablas);
            this.menuNavegacion.Controls.Add(this.Tab_Facturacion);
            this.menuNavegacion.Controls.Add(this.Tab_Seguridad);
            this.menuNavegacion.Controls.Add(this.Tab_Info);
            this.menuNavegacion.Depth = 0;
            this.menuNavegacion.Location = new System.Drawing.Point(0, 0);
            this.menuNavegacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuNavegacion.Multiline = true;
            this.menuNavegacion.Name = "menuNavegacion";
            this.menuNavegacion.SelectedIndex = 0;
            this.menuNavegacion.Size = new System.Drawing.Size(270, 583);
            this.menuNavegacion.TabIndex = 1;
            // 
            // Tab_Principal
            // 
            this.Tab_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Tab_Principal.Controls.Add(this.btnSalir);
            this.Tab_Principal.Controls.Add(this.imgLogoPrincipal);
            this.Tab_Principal.Location = new System.Drawing.Point(4, 40);
            this.Tab_Principal.Name = "Tab_Principal";
            this.Tab_Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Principal.Size = new System.Drawing.Size(262, 539);
            this.Tab_Principal.TabIndex = 0;
            this.Tab_Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = global::Sistema_Facturacion.Properties.Resources.salida;
            this.btnSalir.Location = new System.Drawing.Point(46, 390);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(171, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imgLogoPrincipal
            // 
            this.imgLogoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogoPrincipal.Image = global::Sistema_Facturacion.Properties.Resources.Logo_removebg_preview__1_1;
            this.imgLogoPrincipal.Location = new System.Drawing.Point(3, 4);
            this.imgLogoPrincipal.Name = "imgLogoPrincipal";
            this.imgLogoPrincipal.Size = new System.Drawing.Size(256, 256);
            this.imgLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoPrincipal.TabIndex = 0;
            this.imgLogoPrincipal.TabStop = false;
            // 
            // Tab_Tablas
            // 
            this.Tab_Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Tab_Tablas.Controls.Add(this.imgLogoTablas);
            this.Tab_Tablas.Controls.Add(this.btnProductos);
            this.Tab_Tablas.Controls.Add(this.btnCategoria);
            this.Tab_Tablas.Controls.Add(this.btnClientes);
            this.Tab_Tablas.Location = new System.Drawing.Point(4, 40);
            this.Tab_Tablas.Name = "Tab_Tablas";
            this.Tab_Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Tablas.Size = new System.Drawing.Size(262, 539);
            this.Tab_Tablas.TabIndex = 1;
            this.Tab_Tablas.Text = "Tablas";
            // 
            // imgLogoTablas
            // 
            this.imgLogoTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogoTablas.Image = global::Sistema_Facturacion.Properties.Resources.Logo_removebg_preview__1_1;
            this.imgLogoTablas.Location = new System.Drawing.Point(3, 3);
            this.imgLogoTablas.Name = "imgLogoTablas";
            this.imgLogoTablas.Size = new System.Drawing.Size(256, 256);
            this.imgLogoTablas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoTablas.TabIndex = 1;
            this.imgLogoTablas.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.AutoSize = false;
            this.btnProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProductos.Depth = 0;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.HighEmphasis = true;
            this.btnProductos.Icon = global::Sistema_Facturacion.Properties.Resources.bolsa_de_la_compra;
            this.btnProductos.Location = new System.Drawing.Point(16, 436);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProductos.Size = new System.Drawing.Size(230, 40);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProductos.UseAccentColor = false;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.AutoSize = false;
            this.btnCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCategoria.Depth = 0;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.HighEmphasis = true;
            this.btnCategoria.Icon = global::Sistema_Facturacion.Properties.Resources.menu;
            this.btnCategoria.Location = new System.Drawing.Point(16, 374);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCategoria.Size = new System.Drawing.Size(230, 40);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCategoria.UseAccentColor = false;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.HighEmphasis = true;
            this.btnClientes.Icon = global::Sistema_Facturacion.Properties.Resources.grupo;
            this.btnClientes.Location = new System.Drawing.Point(16, 307);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientes.Size = new System.Drawing.Size(230, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Tab_Facturacion
            // 
            this.Tab_Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Tab_Facturacion.Controls.Add(this.ImgLogoFacturacion);
            this.Tab_Facturacion.Controls.Add(this.btnInforme);
            this.Tab_Facturacion.Controls.Add(this.btnFactura);
            this.Tab_Facturacion.Location = new System.Drawing.Point(4, 40);
            this.Tab_Facturacion.Name = "Tab_Facturacion";
            this.Tab_Facturacion.Size = new System.Drawing.Size(262, 539);
            this.Tab_Facturacion.TabIndex = 3;
            this.Tab_Facturacion.Text = "Facturación";
            // 
            // ImgLogoFacturacion
            // 
            this.ImgLogoFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgLogoFacturacion.Image = global::Sistema_Facturacion.Properties.Resources.Logo_removebg_preview__1_1;
            this.ImgLogoFacturacion.Location = new System.Drawing.Point(3, 3);
            this.ImgLogoFacturacion.Name = "ImgLogoFacturacion";
            this.ImgLogoFacturacion.Size = new System.Drawing.Size(256, 256);
            this.ImgLogoFacturacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogoFacturacion.TabIndex = 4;
            this.ImgLogoFacturacion.TabStop = false;
            // 
            // btnInforme
            // 
            this.btnInforme.AutoSize = false;
            this.btnInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInforme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInforme.Depth = 0;
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.HighEmphasis = true;
            this.btnInforme.Icon = global::Sistema_Facturacion.Properties.Resources.informes;
            this.btnInforme.Location = new System.Drawing.Point(16, 374);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInforme.Size = new System.Drawing.Size(230, 40);
            this.btnInforme.TabIndex = 3;
            this.btnInforme.Text = "Informes";
            this.btnInforme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInforme.UseAccentColor = false;
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.AutoSize = false;
            this.btnFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFactura.Depth = 0;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.HighEmphasis = true;
            this.btnFactura.Icon = global::Sistema_Facturacion.Properties.Resources.factura;
            this.btnFactura.Location = new System.Drawing.Point(16, 307);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFactura.Size = new System.Drawing.Size(230, 40);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFactura.UseAccentColor = false;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // Tab_Seguridad
            // 
            this.Tab_Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Tab_Seguridad.Controls.Add(this.btnSeguridad);
            this.Tab_Seguridad.Controls.Add(this.imgLogoSeguridad);
            this.Tab_Seguridad.Controls.Add(this.btnRoles);
            this.Tab_Seguridad.Controls.Add(this.btnEmpleados);
            this.Tab_Seguridad.Location = new System.Drawing.Point(4, 40);
            this.Tab_Seguridad.Name = "Tab_Seguridad";
            this.Tab_Seguridad.Size = new System.Drawing.Size(262, 539);
            this.Tab_Seguridad.TabIndex = 5;
            this.Tab_Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AutoSize = false;
            this.btnSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeguridad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeguridad.Depth = 0;
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.HighEmphasis = true;
            this.btnSeguridad.Icon = global::Sistema_Facturacion.Properties.Resources.seguridad;
            this.btnSeguridad.Location = new System.Drawing.Point(16, 441);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeguridad.Size = new System.Drawing.Size(230, 40);
            this.btnSeguridad.TabIndex = 5;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeguridad.UseAccentColor = false;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // imgLogoSeguridad
            // 
            this.imgLogoSeguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogoSeguridad.Image = global::Sistema_Facturacion.Properties.Resources.Logo_removebg_preview__1_1;
            this.imgLogoSeguridad.Location = new System.Drawing.Point(3, 3);
            this.imgLogoSeguridad.Name = "imgLogoSeguridad";
            this.imgLogoSeguridad.Size = new System.Drawing.Size(256, 256);
            this.imgLogoSeguridad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoSeguridad.TabIndex = 4;
            this.imgLogoSeguridad.TabStop = false;
            // 
            // btnRoles
            // 
            this.btnRoles.AutoSize = false;
            this.btnRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRoles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRoles.Depth = 0;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.HighEmphasis = true;
            this.btnRoles.Icon = global::Sistema_Facturacion.Properties.Resources.roles;
            this.btnRoles.Location = new System.Drawing.Point(16, 374);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRoles.Size = new System.Drawing.Size(230, 40);
            this.btnRoles.TabIndex = 3;
            this.btnRoles.Text = "Roles";
            this.btnRoles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRoles.UseAccentColor = false;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = false;
            this.btnEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleados.Depth = 0;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.HighEmphasis = true;
            this.btnEmpleados.Icon = global::Sistema_Facturacion.Properties.Resources.empleados;
            this.btnEmpleados.Location = new System.Drawing.Point(16, 307);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEmpleados.Size = new System.Drawing.Size(230, 40);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleados.UseAccentColor = false;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Tab_Info
            // 
            this.Tab_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Tab_Info.Controls.Add(this.imgLogoInformacion);
            this.Tab_Info.Controls.Add(this.btnAyuda);
            this.Tab_Info.Controls.Add(this.btnInformacion);
            this.Tab_Info.Location = new System.Drawing.Point(4, 40);
            this.Tab_Info.Name = "Tab_Info";
            this.Tab_Info.Size = new System.Drawing.Size(262, 539);
            this.Tab_Info.TabIndex = 4;
            this.Tab_Info.Text = "Información";
            // 
            // imgLogoInformacion
            // 
            this.imgLogoInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogoInformacion.Image = global::Sistema_Facturacion.Properties.Resources.Logo_removebg_preview__1_1;
            this.imgLogoInformacion.Location = new System.Drawing.Point(3, 4);
            this.imgLogoInformacion.Name = "imgLogoInformacion";
            this.imgLogoInformacion.Size = new System.Drawing.Size(256, 256);
            this.imgLogoInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoInformacion.TabIndex = 4;
            this.imgLogoInformacion.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.AutoSize = false;
            this.btnAyuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAyuda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAyuda.Depth = 0;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.HighEmphasis = true;
            this.btnAyuda.Icon = global::Sistema_Facturacion.Properties.Resources.ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(16, 342);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAyuda.Size = new System.Drawing.Size(230, 40);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAyuda.UseAccentColor = false;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.AutoSize = false;
            this.btnInformacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInformacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInformacion.Depth = 0;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.HighEmphasis = true;
            this.btnInformacion.Icon = global::Sistema_Facturacion.Properties.Resources.informacion;
            this.btnInformacion.Location = new System.Drawing.Point(16, 409);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInformacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInformacion.Size = new System.Drawing.Size(230, 40);
            this.btnInformacion.TabIndex = 5;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInformacion.UseAccentColor = false;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // TabOpcInicio
            // 
            this.TabOpcInicio.BaseTabControl = this.menuNavegacion;
            this.TabOpcInicio.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabOpcInicio.Depth = 0;
            this.TabOpcInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabOpcInicio.Location = new System.Drawing.Point(306, 26);
            this.TabOpcInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcInicio.Name = "TabOpcInicio";
            this.TabOpcInicio.Size = new System.Drawing.Size(891, 37);
            this.TabOpcInicio.TabIndex = 1;
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcInicio);
            this.Controls.Add(this.Panel_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Inicio";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación";
            this.Panel_Principal.ResumeLayout(false);
            this.Panel_Navegacion.ResumeLayout(false);
            this.menuNavegacion.ResumeLayout(false);
            this.Tab_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoPrincipal)).EndInit();
            this.Tab_Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTablas)).EndInit();
            this.Tab_Facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoFacturacion)).EndInit();
            this.Tab_Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSeguridad)).EndInit();
            this.Tab_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Principal;
        private System.Windows.Forms.Panel Panel_Navegacion;
        private MaterialSkin.Controls.MaterialTabControl menuNavegacion;
        private System.Windows.Forms.TabPage Tab_Principal;
        private System.Windows.Forms.TabPage Tab_Tablas;
        private System.Windows.Forms.TabPage Tab_Facturacion;
        private System.Windows.Forms.TabPage Tab_Info;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcInicio;
        private System.Windows.Forms.PictureBox imgLogoPrincipal;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private System.Windows.Forms.TabPage Tab_Seguridad;
        private MaterialSkin.Controls.MaterialButton btnProductos;
        private MaterialSkin.Controls.MaterialButton btnCategoria;
        private MaterialSkin.Controls.MaterialButton btnClientes;
        private System.Windows.Forms.PictureBox imgLogoTablas;
        private System.Windows.Forms.PictureBox ImgLogoFacturacion;
        private MaterialSkin.Controls.MaterialButton btnInforme;
        private MaterialSkin.Controls.MaterialButton btnFactura;
        private MaterialSkin.Controls.MaterialButton btnSeguridad;
        private System.Windows.Forms.PictureBox imgLogoSeguridad;
        private MaterialSkin.Controls.MaterialButton btnRoles;
        private MaterialSkin.Controls.MaterialButton btnEmpleados;
        private System.Windows.Forms.PictureBox imgLogoInformacion;
        private MaterialSkin.Controls.MaterialButton btnAyuda;
        private MaterialSkin.Controls.MaterialButton btnInformacion;
        private System.Windows.Forms.Panel panelContenedor;
    }
}