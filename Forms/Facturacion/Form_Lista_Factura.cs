using Sistema_Facturacion.Class;
using Sistema_Facturacion.Forms.Cliente;
using Sistema_Facturacion.Forms.Facturacion.CRUD_Factura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Lista_Factura : Form
    {
        ConnectionDB dataBase = new ConnectionDB();

        public Form_Lista_Factura()
        {
            InitializeComponent();
        }

        //Random random = new Random();
        private void mostrarFacturas()
        {
            var listFactura = dataBase.GetFacturaList();

            foreach (var factura in listFactura)
            {
                string fecha = $"{factura.DateTime.Year.ToString()}/{factura.DateTime.Month.ToString()}/{factura.DateTime.Day.ToString()}";

                lstFactura.Rows.Add(factura.IdFactura, factura.NombreCliente, factura.NombreEmpleado, fecha, factura.Estado);

            }
        }           

        private void btn_nuevo_usuario_Click(object sender, EventArgs e)
        {
            Form_Editar_Clientes clientes = new Form_Editar_Clientes();
            clientes.IdCliente = 0;
            clientes.ShowDialog();
        }

        private void lst_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstFactura.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                int posActual = lstFactura.CurrentRow.Index;
                if (MessageBox.Show("¿Deseas borrar una factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Eliminando factura {e.RowIndex} con el id: {posActual}", "Borrando datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lstFactura.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstFactura.CurrentRow.Index;
                Form_Editar_Clientes clientes = new Form_Editar_Clientes();
                clientes.IdCliente = int.Parse(lstFactura[0, posActual].Value.ToString());
                clientes.ShowDialog();
            }
        }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Lista_Factura_Load(object sender, EventArgs e)
        {
            mostrarFacturas();
        }

        private void btn_nuevo_factura_Click_1(object sender, EventArgs e)
        {
            Form_Factura_Nuevo nueva_factura = new Form_Factura_Nuevo();
            nueva_factura.IdFactura = 0;
            nueva_factura.ShowDialog();
        }

        private void lst_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstFactura.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = lstFactura.CurrentRow.Index;
                if (MessageBox.Show("¿Deseas borrar una factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Eliminando factura {e.RowIndex} con el id: {posActual}", "Borrando datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lstFactura.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = lstFactura.CurrentRow.Index;
                Form_Facturas_Editar editar_Factura = new Form_Facturas_Editar();
                editar_Factura.IdFactura = int.Parse(lstFactura[0, posActual].Value.ToString());
                editar_Factura.ShowDialog();
            }
        }

        private void btn_nuevo_usuario_Click_1(object sender, EventArgs e)
        {
            Form_Factura_Nuevo factura_Nueva = new Form_Factura_Nuevo();
            factura_Nueva.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
