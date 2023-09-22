using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Facturacion.Class;
using Sistema_Facturacion.Class.Objetos;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Nuevo_Productos : MaterialForm
    {
        public Form_Nuevo_Productos()
        {
            InitializeComponent();
        }

        ConnectionDB dataBase = new ConnectionDB();


        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarOpciones()
        {
            var listCategorias = dataBase.GetCategoriaProductoList();

            foreach (var categoria in listCategorias)
            {
                txtCategoria.Items.Add(categoria.Descripcion);
            }
        }

        private void Form_Nuevo_Productos_Load(object sender, EventArgs e)
        {
            mostrarOpciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text) || string.IsNullOrEmpty(txtCodigoReferencia.Text) || string.IsNullOrEmpty(txtPrecioCompra.Text) || string.IsNullOrEmpty(txtPrecioVenta.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtRutaImg.Text) || string.IsNullOrEmpty(txtDetalles.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var idCategoria = dataBase.GetCategoriaProductoId(txtCategoria.Text);

                Obj_Producto producto = new Obj_Producto();

                producto.Nombre = txtNombreProducto.Text;
                producto.Codigo = txtCodigoReferencia.Text;
                producto.PrecioCompra = int.Parse(txtPrecioCompra.Text);
                producto.PrecioVenta = int.Parse(txtPrecioVenta.Text);
                producto.CantidadStock = int.Parse(txtCantidad.Text);
                producto.IdCategoria = idCategoria.IdCategoriaProducto;
                producto.RutaFoto = txtRutaImg.Text;
                producto.Detalle = txtDetalles.Text;                

                var newUsuario = dataBase.New_Producto(producto);

                if (newUsuario == 1)
                {
                    MessageBox.Show($"Los datos se registraron satisfactoriamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }
        }
    }
}
