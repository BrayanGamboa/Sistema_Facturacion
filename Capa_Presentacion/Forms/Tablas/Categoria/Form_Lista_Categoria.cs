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

namespace Sistema_Facturacion.Forms.Tablas
{
    public partial class Form_Lista_Categoria : Form
    {

        public Form_Lista_Categoria()
        {
            InitializeComponent();
        }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nueva_categoria_Click(object sender, EventArgs e)
        {
            Form_Nueva_Categoria_Productos form_Nueva_Categoria = new Form_Nueva_Categoria_Productos();
            form_Nueva_Categoria.ShowDialog();
        }

        private void lstCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();

            if (lstCategorias.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                string id_categoria = lstCategorias.Rows[lstCategorias.CurrentRow.Index].Cells["id_categoria"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj_Categoria_Producto.DeleteCategoriaProductoId(int.Parse(id_categoria)) == 1)
                    {
                        MessageBox.Show($"Producto eliminando con el id: {id_categoria}", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (lstCategorias.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstCategorias.CurrentRow.Index;
                Form_Editar_Categoria_Productos editar_Categoria = new Form_Editar_Categoria_Productos();
                editar_Categoria.IdCategoria = int.Parse(lstCategorias[0, posActual].Value.ToString());
                editar_Categoria.ShowDialog();
            }
        }

        private void mostrarCategorias()
        {
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();
            var listCategoria = obj_Categoria_Producto.GetCategoriaProductoList();

            foreach (var categoria in listCategoria)
            {
                lstCategorias.Rows.Add(categoria.IdCategoriaProducto, categoria.Descripcion);
            }
        }

        private void Form_Lista_Categoria_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstCategorias.Rows.Clear();
                var categoria = obj_Categoria_Producto.GetCategoriaProductoForName(txtNombreCategoria.Text);
                lstCategorias.Rows.Add(categoria.IdCategoriaProducto, categoria.Descripcion);
            }

        }
    }
}
