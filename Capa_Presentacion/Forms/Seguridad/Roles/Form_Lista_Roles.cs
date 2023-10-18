using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class;
using Sistema_Facturacion.Forms.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Forms.Seguridad.Roles
{
    public partial class Form_Lista_Roles : Form
    {
        public Form_Lista_Roles()
        {
            InitializeComponent();
        }

        

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_Rol obj_Rol = new Obj_Rol();
            if (lstRol.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                string id_rol = lstRol.Rows[lstRol.CurrentRow.Index].Cells["id_rol"].Value.ToString();
                if (MessageBox.Show("¿Deseas borrar un rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj_Rol.DeleteRolForId(int.Parse(id_rol)) == 1)
                    {
                        MessageBox.Show($"Rol eliminando con el id: {id_rol}", "Rol eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                
            }
            else if (lstRol.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstRol.CurrentRow.Index;
                Form_Editar_Rol_Empleado rol_Empleado = new Form_Editar_Rol_Empleado();
                rol_Empleado.IdRol = int.Parse(lstRol[0, posActual].Value.ToString());
                rol_Empleado.ShowDialog();
            }
        }

        private void Form_Lista_Roles_Load(object sender, EventArgs e)
        {
            mostrarRoles();
        }

        private void mostrarRoles()
        {
            Obj_Rol obj_Rol = new Obj_Rol();    
            var listRol = obj_Rol.GetRolList();

            foreach (var rol in listRol)
            {
                lstRol.Rows.Add(rol.IdRol, rol.NombreRol);
            }
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            Form_Nuevo_Rol_Empleados nuevo_Rol_Empleados = new Form_Nuevo_Rol_Empleados();
            nuevo_Rol_Empleados.ShowDialog();
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            Obj_Rol obj_Rol = new Obj_Rol();
            if (string.IsNullOrEmpty(txtNombreRol.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstRol.Rows.Clear();
                var rol = obj_Rol.GetRolId(txtNombreRol.Text);
                lstRol.Rows.Add(rol.IdRol, rol.NombreRol);
            }
        }
    }
}
