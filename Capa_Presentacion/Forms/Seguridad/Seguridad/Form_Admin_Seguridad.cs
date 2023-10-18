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
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class;

namespace Sistema_Facturacion.Forms.Seguridad
{
    public partial class Form_Admin_Seguridad : Form
    {
        public Form_Admin_Seguridad()
        {
            InitializeComponent();
        }
       
        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarOpciones()
        {            
            Obj_Seguridad obj_Seguridad = new Obj_Seguridad();
            var listSeguridad = obj_Seguridad.GetSeguridadList();

            foreach (var seguridad in listSeguridad)
            {
                listEmpleado.Items.Add(seguridad.NombreEmpleado);                
            }
        }

        private void Form_Admin_Seguridad_Load(object sender, EventArgs e)
        {
            mostrarOpciones();
        }

        private void btnConsultarCredenciales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listEmpleado.Text))
            {
                    MessageBox.Show("Faltan campos por seleccionar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Seguridad obj_Seguridad = new Obj_Seguridad();
                string nombreEmpleado = listEmpleado.Text;
                var credenciales = obj_Seguridad.GetCredenciales(nombreEmpleado);
                if (credenciales.NombreUsuario == "" || credenciales.Contrasena == "")
                {
                    MessageBox.Show("El usuario no tiene credenciales", "Crea las nuevas credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                txtUsuario.Text = credenciales.NombreUsuario;
                txtContrasena.Text = credenciales.Contrasena;
            }


        }

        private void btnActualizarCredenciales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(listEmpleado.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Login usuario = new Obj_Login();
                Obj_Empleado obj_empleado = new Obj_Empleado();
                usuario.IdEmpleado = obj_empleado.GetEmpleadoId(listEmpleado.Text).IdEmpleado;
                usuario.Usuario = txtUsuario.Text;
                usuario.Contrasena = txtContrasena.Text;

                int respuesta = usuario.UpdateCredenciales(usuario);

                if (respuesta == 1)
                {
                    MessageBox.Show("Credenciales actualizadas con exito", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se actualizaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnEliminarCredenciales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listEmpleado.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Login usuario = new Obj_Login();
                Obj_Empleado obj_empleado = new Obj_Empleado();
                usuario.IdEmpleado = obj_empleado.GetEmpleadoId(listEmpleado.Text).IdEmpleado;
                usuario.Usuario = "";
                usuario.Contrasena = "";

                int respuesta = usuario.UpdateCredenciales(usuario);

                if (respuesta == 1)
                {
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                    MessageBox.Show("Credenciales elimminadas con exito", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se eliminaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
