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
    public partial class Form_Admin_Seguridad : Form
    {
        public Form_Admin_Seguridad()
        {
            InitializeComponent();
        }

        ConnectionDB dataBase = new ConnectionDB();


        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarOpciones()
        {
            var listSeguridad = dataBase.GetSeguridadList();

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
                string nombreEmpleado = listEmpleado.Text;
                var credenciales = dataBase.GetCredenciales(nombreEmpleado);
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
                usuario.IdEmpleado = dataBase.GetEmpleadoId(listEmpleado.Text).IdEmpleado;
                usuario.Usuario = txtUsuario.Text;
                usuario.Contrasena = txtContrasena.Text;

                int respuesta = dataBase.UpdateCredenciales(usuario);

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
                usuario.IdEmpleado = dataBase.GetEmpleadoId(listEmpleado.Text).IdEmpleado;
                usuario.Usuario = "";
                usuario.Contrasena = "";

                int respuesta = dataBase.UpdateCredenciales(usuario);

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
