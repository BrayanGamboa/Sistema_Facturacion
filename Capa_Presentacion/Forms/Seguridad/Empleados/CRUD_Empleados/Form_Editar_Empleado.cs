using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Sistema_Facturacion.Forms.Seguridad
{
    public partial class Form_Editar_Empleado : MaterialForm
    {
        public Form_Editar_Empleado()
        {
            InitializeComponent();
        }        

        private int idEmpleado;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Editar_Empleado_Load(object sender, EventArgs e)
        {
            Obj_Empleado obj_empleado =new Obj_Empleado();
            var datosEmpleado = obj_empleado.GetDatosEmpleadoId(idEmpleado);

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
                
                Obj_Empleado empleado = new Obj_Empleado();
                Obj_Rol obj_Rol = new Obj_Rol();
                empleado.Nombre = txtNombreEmpleado.Text;
                empleado.Documento = int.Parse(txtDocumentoEmpleado.Text);
                empleado.Direccion = txtDireccionEmpleado.Text;
                empleado.Telefono = txtTelefonoEmpleado.Text;
                empleado.Email = txtEmailEmpleado.Text;
                empleado.IdRolEmpleado = obj_Rol.GetRolId(txtRolEmpleado.Text).IdRol;
                empleado.DatosAdicionales = txtNotas.Text;
                empleado.IdEmpleado = idEmpleado;

                int resultado = empleado.UpdateEmpleado(empleado);

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
            Obj_Rol obj_Rol = new Obj_Rol();
            var listRol = obj_Rol.GetRolList();

            foreach (var rol in listRol)
            {
                txtRolEmpleado.Items.Add(rol.NombreRol);
            }
        }

        
    }
}
