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

namespace Sistema_Facturacion.Forms.Tablas.Productos
{
    public partial class Form_Lista_Productos : Form
    {
        ConnectionDB dataBase = new ConnectionDB();
        public Form_Lista_Productos()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (lstProducto.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                string id_Producto = lstProducto.Rows[lstProducto.CurrentRow.Index].Cells["id_producto"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataBase.DeleteProductoForId(int.Parse(id_Producto)) == 1)
                    {
                        MessageBox.Show($"Producto eliminando con el id: {id_Producto}", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (lstProducto.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstProducto.CurrentRow.Index;
                Form_Editar_Productos productos = new Form_Editar_Productos();
                productos.IdProducto = int.Parse(lstProducto[0, posActual].Value.ToString());
                productos.ShowDialog();
            }
        }


        private void mostrarProductos()
        {
            var listProducto = dataBase.GetProductoList();

            foreach (var producto in listProducto)
            {
                lstProducto.Rows.Add(producto.IdProducto, producto.Nombre, producto.Categoria, producto.PrecioVenta, producto.CantidadStock);
            }

        }

        private void Form_Lista_Productos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Form_Nuevo_Productos nuevo_Producto = new Form_Nuevo_Productos();
            nuevo_Producto.ShowDialog();
        }
    }
}
