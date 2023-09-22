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

namespace Sistema_Facturacion.Forms.Tablas
{
    public partial class Form_Lista_Categoria : Form
    {
        ConnectionDB dataBase = new ConnectionDB();

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
            if (lstCategorias.Columns[e.ColumnIndex].Name == "btn_borrar")
            {
                int posActual = lstCategorias.CurrentRow.Index;
                if (MessageBox.Show("¿Deseas borrar una categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Eliminando categoría {e.RowIndex} con el id: {posActual}", "Borrando datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var listCategoria = dataBase.GetCategoriaProductoList();

            foreach (var categoria in listCategoria)
            {
                lstCategorias.Rows.Add(categoria.IdCategoriaProducto, categoria.Descripcion);
            }
        }

        private void Form_Lista_Categoria_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }
    }
}
