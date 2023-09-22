using Sistema_Facturacion.Class;
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

        ConnectionDB dataBase = new ConnectionDB();

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstRol.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                int posActual = lstRol.CurrentRow.Index;
                if (MessageBox.Show("¿Deseas borrar un rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Eliminando rol {e.RowIndex} con el id: {posActual}", "Borrando datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            var listRol = dataBase.GetRolList();

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
    }
}
