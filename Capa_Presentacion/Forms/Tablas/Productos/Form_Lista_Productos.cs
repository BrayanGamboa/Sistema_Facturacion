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
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class.Tablas;

namespace Sistema_Facturacion.Forms.Tablas.Productos
{
    public partial class Form_Lista_Productos : Form
    {
        
        public Form_Lista_Productos()
        {
            InitializeComponent();
        }

        

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_Producto obj_Producto = new Obj_Producto();

            if (lstProducto.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                string id_Producto = lstProducto.Rows[lstProducto.CurrentRow.Index].Cells["id_producto"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj_Producto.DeleteProductoForId(int.Parse(id_Producto)) == 1)
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
            Obj_Producto obj_Producto = new Obj_Producto();
            var listProducto = obj_Producto.GetProductoList();

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

        private void btn_buscar_productos_Click(object sender, EventArgs e)
        {
            Obj_Producto obj_Producto = new Obj_Producto();

            if (string.IsNullOrEmpty(txt_nombre_producto.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var producto = obj_Producto.GetProductoForName(txt_nombre_producto.Text);
                lstProducto.Rows.Clear();
                lstProducto.Rows.Add(producto.IdProducto, producto.Nombre, producto.Categoria, producto.PrecioVenta, producto.CantidadStock);
            }

        }
    }
}
