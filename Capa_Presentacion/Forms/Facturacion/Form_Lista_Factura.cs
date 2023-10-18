using Capa_Logica_De_Negocios.Class.Facturacion;
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
using Capa_Logica_De_Negocios;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Lista_Factura : Form
    {
        

        public Form_Lista_Factura()
        {
            InitializeComponent();
        }

        
        private void mostrarFacturas()
        {
            Obj_Factura obj_Factura = new Obj_Factura();
            var listFactura = obj_Factura.GetFacturaList();

            foreach (var factura in listFactura)
            {
                string fecha = $"{factura.DateTime.Year}/{factura.DateTime.Month}/{factura.DateTime.Day}";

                lstFactura.Rows.Add(factura.IdFactura, factura.NombreCliente, factura.NombreEmpleado, fecha, factura.Estado);
            }
        }           

        private void btn_nuevo_usuario_Click(object sender, EventArgs e)
        {
            Form_Factura_Nuevo factura = new Form_Factura_Nuevo();
            factura.IdFactura = 0;
            factura.ShowDialog();
        }

        private void lst_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_Factura obj_Factura = new Obj_Factura();
            if (lstFactura.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                string id_factura = lstFactura.Rows[lstFactura.CurrentRow.Index].Cells["id_factura"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj_Factura.DeleteFacturaForId(int.Parse(id_factura)) == 1)
                    {
                        MessageBox.Show($"Producto eliminando con el id: {id_factura}", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (lstFactura.Columns[e.ColumnIndex].Name == "btnEditar")
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
            Obj_Factura obj_Factura = new Obj_Factura();  
            if (lstFactura.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                string id_Producto = lstFactura.Rows[lstFactura.CurrentRow.Index].Cells["id_factura"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj_Factura.DeleteFacturaForId(int.Parse(id_Producto)) == 1)
                    {
                        MessageBox.Show($"Producto eliminando con el id: {id_Producto}", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            Obj_Factura obj_Factura = new Obj_Factura();
            if (string.IsNullOrEmpty(txtBuscarFactura.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try {
                    var factura = obj_Factura.GetFacturaForIdBusqueda(int.Parse(txtBuscarFactura.Text));
                    lstFactura.Rows.Clear();
                    string fecha = $"{factura.DateTime.Year}/{factura.DateTime.Month}/{factura.DateTime.Day}";
                    lstFactura.Rows.Add(factura.IdFactura, factura.NombreCliente, factura.NombreEmpleado, fecha, factura.Estado);
                }
                catch {
                MessageBox.Show("Por favor verifica que estés ingresando el ID de la factura", "Error de parseo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
    }
}
