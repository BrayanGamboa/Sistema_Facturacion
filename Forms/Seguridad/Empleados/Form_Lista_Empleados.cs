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

namespace Sistema_Facturacion.Forms.Seguridad.Empleados
{
    public partial class Form_Lista_Empleados : Form
    {
        public Form_Lista_Empleados()
        {
            InitializeComponent();
        }
        ConnectionDB dataBase = new ConnectionDB();

        Random random = new Random();

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mostrarEmpleados()
        {
            var listEmpleados = dataBase.GetEmpleadosList();

            foreach (var empleado in listEmpleados)
            {
                lstEmpleados.Rows.Add(empleado.IdEmpleado, empleado.Nombre, empleado.Documento, empleado.Telefono);
            }
        }

        private void Form_Lista_Empleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void lstEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstEmpleados.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                int posActual = lstEmpleados.CurrentRow.Index;

                string id_empleado = lstEmpleados.Rows[lstEmpleados.CurrentRow.Index].Cells["id_empleado"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataBase.DeleteEmpleadoForId(int.Parse(id_empleado)) == 1)
                    {
                        MessageBox.Show($"Empleado eliminando  con el id: {id_empleado}", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
            }
            else if (lstEmpleados.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstEmpleados.CurrentRow.Index;
                Form_Editar_Empleado empleado = new Form_Editar_Empleado();
                empleado.IdEmpleado = int.Parse(lstEmpleados[0, posActual].Value.ToString());
                empleado.ShowDialog();
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Form_Nuevo_Empleados form_Nuevo_Empleados = new Form_Nuevo_Empleados();
            form_Nuevo_Empleados.ShowDialog();
        }

        
    }

    
}
