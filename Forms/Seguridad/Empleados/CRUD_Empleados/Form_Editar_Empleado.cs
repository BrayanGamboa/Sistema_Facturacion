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
using Sistema_Facturacion.Class;
using Sistema_Facturacion.Class.Objetos;

namespace Sistema_Facturacion.Forms.Seguridad
{
    public partial class Form_Editar_Empleado : MaterialForm
    {
        public Form_Editar_Empleado()
        {
            InitializeComponent();
        }

        ConnectionDB database = new ConnectionDB();

        private int idEmpleado;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Editar_Empleado_Load(object sender, EventArgs e)
        {
            var datosEmpleado = database.GetDatosEmpleadoId(idEmpleado);

            lblIdEmpleado.Text = $"ID: {idEmpleado}";
            txtNombreEmpleado.Text = datosEmpleado.Nombre;
            txtDocumentoEmpleado.Text = datosEmpleado.Documento.ToString();
            txtDireccionEmpleado.Text = datosEmpleado.Direccion;
            txtTelefonoEmpleado.Text = datosEmpleado.Telefono;
            txtEmailEmpleado.Text = datosEmpleado.Email;
            txtRolEmpleado.Text = datosEmpleado.NombreRol;
            txtNotas.Text = datosEmpleado.DatosAdicionales;

            mostrarOpciones();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEmpleado.Text) || string.IsNullOrEmpty(txtDocumentoEmpleado.Text) || string.IsNullOrEmpty(txtDireccionEmpleado.Text) || string.IsNullOrEmpty(txtTelefonoEmpleado.Text) || string.IsNullOrEmpty(txtEmailEmpleado.Text) || string.IsNullOrEmpty(txtRolEmpleado.Text) || string.IsNullOrEmpty(txtNotas.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                Empleado empleado = new Empleado();
                empleado.Nombre = txtNombreEmpleado.Text;
                empleado.Documento = int.Parse(txtDocumentoEmpleado.Text);
                empleado.Direccion = txtDireccionEmpleado.Text;
                empleado.Telefono = txtTelefonoEmpleado.Text;
                empleado.Email = txtEmailEmpleado.Text;
                empleado.IdRolEmpleado = database.GetRolId(txtRolEmpleado.Text).IdRol;
                empleado.DatosAdicionales = txtNotas.Text;
                empleado.IdEmpleado = idEmpleado;

                int resultado = database.UpdateEmpleado(empleado);

                if (resultado == 1)
                {
                    MessageBox.Show("Datos actualizados en la BD", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualiozar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mostrarOpciones()
        {
            var listRol = database.GetRolList();

            foreach (var rol in listRol)
            {
                txtRolEmpleado.Items.Add(rol.NombreRol);
            }
        }

        
    }
}
