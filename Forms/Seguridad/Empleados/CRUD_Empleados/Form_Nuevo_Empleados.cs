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
    public partial class Form_Nuevo_Empleados : MaterialForm
    {
        public Form_Nuevo_Empleados()
        {
            InitializeComponent();
        }
        ConnectionDB dataBase = new ConnectionDB();


        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEmpleado.Text) || string.IsNullOrEmpty(txtDocumentoEmpleado.Text) || string.IsNullOrEmpty(txtDireccionEmpleado.Text) || string.IsNullOrEmpty(txtTelefonoEmpleado.Text) || string.IsNullOrEmpty(txtEmailEmpleado.Text) || string.IsNullOrEmpty(txtRolEmpleado.Text) || string.IsNullOrEmpty(txtNotas.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var idRol = dataBase.GetRolId(txtRolEmpleado.Text);

                Empleado empleado = new Empleado();

                empleado.Nombre = txtNombreEmpleado.Text;
                empleado.Documento = int.Parse(txtDocumentoEmpleado.Text);
                empleado.Direccion = txtDireccionEmpleado.Text;
                empleado.Telefono = txtTelefonoEmpleado.Text;
                empleado.Email = txtEmailEmpleado.Text;
                empleado.IdRolEmpleado = idRol.IdRol;
                empleado.DatosAdicionales = txtNotas.Text;

                var newEmpleado = dataBase.New_Empleado(empleado);

                if (newEmpleado == 1)
                {
                    MessageBox.Show("Empleado guardado con exito", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void mostrarOpciones()
        {
            var listRolEmpleado = dataBase.GetRolList();
            

            foreach (var rol in listRolEmpleado)
            {
                txtRolEmpleado.Items.Add(rol.NombreRol);
            }

            
        }

        private void Form_Nuevo_Empleados_Load(object sender, EventArgs e)
        {
            mostrarOpciones();
        }
    }
}
