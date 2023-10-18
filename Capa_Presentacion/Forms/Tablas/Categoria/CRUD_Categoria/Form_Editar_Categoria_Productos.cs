using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_De_Negocios.Class.Tablas;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Editar_Categoria_Productos : MaterialForm
    {
        public Form_Editar_Categoria_Productos()
        {
            InitializeComponent();
        }

        private int idCategoria;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }


        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Editar_Categoria_Productos_Load(object sender, EventArgs e)
        {
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();
            var datosCategoria = obj_Categoria_Producto.GetCategoriaProductoId_(idCategoria);

            lblIdCategoria.Text = $"ID: {datosCategoria.IdCategoriaProducto}";
            txtCategoria.Text = datosCategoria.Descripcion;

        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();

            if (string.IsNullOrEmpty(lblIdCategoria.Text) || string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                obj_Categoria_Producto.IdCategoriaProducto = idCategoria;
                obj_Categoria_Producto.Descripcion = txtCategoria.Text;

            }
            var respuesta = obj_Categoria_Producto.UpdateCategoriaProducto(obj_Categoria_Producto);
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
