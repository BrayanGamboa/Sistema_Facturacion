using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_De_Negocios.Class;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Facturacion.Forms.Seguridad
{
    public partial class Form_Editar_Rol_Empleado : MaterialForm
    {
        public Form_Editar_Rol_Empleado()
        {
            InitializeComponent();
        }
        private int idRol;

        public int IdRol { get => idRol; set => idRol = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Rol_Empleado_Load(object sender, EventArgs e)
        {
            Obj_Rol obj_Rol = new Obj_Rol();
            var datosRol = obj_Rol.GetNombreRolId(idRol);
            lblIdRol.Text = $"ID: {idRol}";
            txtRol.Text = datosRol.NombreRol;            
        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIdRol.Text) || string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Rol obj_Rol = new Obj_Rol();
                obj_Rol.NombreRol = txtRol.Text;
                obj_Rol.IdRol = idRol;
                var respuesta = obj_Rol.UpdateRol(obj_Rol);
                if (respuesta == 1)
                {
                    MessageBox.Show("Datos actualizados en la BD", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualiozar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
