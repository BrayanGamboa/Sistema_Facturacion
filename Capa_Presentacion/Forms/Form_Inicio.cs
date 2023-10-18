using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Facturacion.Forms;
using Sistema_Facturacion.Forms.Facturacion;
using Sistema_Facturacion.Forms.Informacion;
using Sistema_Facturacion.Forms.Seguridad;
using Sistema_Facturacion.Forms.Seguridad.Empleados;
using Sistema_Facturacion.Forms.Seguridad.Roles;
using Sistema_Facturacion.Forms.Tablas;
using Sistema_Facturacion.Forms.Tablas.Productos;

namespace Sistema_Facturacion
{
    public partial class Form_Inicio : MaterialForm
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }


        private void mostrarForm(Form form) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            form.Show();
        }

        //Los botones correspondientes para el perfil de tablas
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form_Lista_Clientes form_Lista_Clientes = new Form_Lista_Clientes();
            mostrarForm(form_Lista_Clientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form_Lista_Productos form_Productos = new Form_Lista_Productos();
            mostrarForm(form_Productos);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Form_Lista_Categoria form_Categoria = new Form_Lista_Categoria();
            mostrarForm(form_Categoria);
        }

        //Los botones correspondientes para el perfil de facturación
        private void btnFactura_Click(object sender, EventArgs e)
        {
            Form_Lista_Factura form_Facturas = new Form_Lista_Factura();
            mostrarForm(form_Facturas);
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            Form_Informe form_Informes = new Form_Informe();
            mostrarForm(form_Informes);
        }

        //Los botones correspondientes para el perfil de seguridad
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form_Lista_Empleados form_Empleados = new Form_Lista_Empleados();
            mostrarForm(form_Empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Form_Lista_Roles form_Rol_Empleado = new Form_Lista_Roles();
            mostrarForm(form_Rol_Empleado);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            Form_Admin_Seguridad form_Admin = new Form_Admin_Seguridad();
            mostrarForm(form_Admin);
        }

        //Los botones correspondientes para el perfil de información
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Form_Ayuda form_Ayuda = new Form_Ayuda();
            mostrarForm(form_Ayuda);
        }
        
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Form_Informacion form_Informacion = new Form_Informacion();
            mostrarForm(form_Informacion);
        }


        //Es el encargado de dirigir al usuario al login
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        
    }
}
