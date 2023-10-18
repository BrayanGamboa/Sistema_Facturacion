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
    public partial class Form_Nuevo_Rol_Empleados : MaterialForm
    {
        public Form_Nuevo_Rol_Empleados()
        {
            InitializeComponent();
        }
        

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Rol rol = new Obj_Rol();
                rol.NombreRol = txtRol.Text;

                var newRol = rol.New_Rol(rol);

                if (newRol == 1)
                {
                    MessageBox.Show("Rol guardado con exito", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
