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
    public partial class Form_Editar_Productos : MaterialForm
    {
        public Form_Editar_Productos()
        {
            InitializeComponent();
        }

        ConnectionDB database = new ConnectionDB();

        private int idProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Editar_Productos_Load(object sender, EventArgs e)
        {
            
            var datosEmpleado = database.GetProductoForId(IdProducto);

            lblIdProducto.Text = $"ID: {idProducto}";
            txtNombreProducto.Text = datosEmpleado.Nombre;
            txtCodigoReferenciaProducto.Text = datosEmpleado.Codigo;
            txtPrecioCompraProducto.Text = datosEmpleado.PrecioCompra.ToString();
            txtPrecioVenta.Text = datosEmpleado.PrecioVenta.ToString();
            txtCantidad.Text = datosEmpleado.CantidadStock.ToString();            
            txtRutaImg.Text = datosEmpleado.RutaFoto;
            txtDetalles.Text = datosEmpleado.Detalle;

            //lblIdProducto.Text = $"ID: {idProducto}";
            //txtNombreProducto.Text = "Producto 1";
            //txtCodigoReferenciaProducto.Text = "12345";
            //txtPrecioCompraProducto.Text = "$ 20000";
            //txtPrecioVenta.Text = "30000";
            //txtCantidad.Text = "40";
            //txtRutaImg.Text = "img.com";
            //txtDetalles.Text = "Lorem ipsum dolor sit amet consectetur adipiscing elit turpis, proin class facilisi vitae fusce conubia auctor consequat curabitur, sociis placerat neque sem ac sociosqu cras.";

            mostrarOpciones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIdProducto.Text) || string.IsNullOrEmpty(txtNombreProducto.Text) || string.IsNullOrEmpty(txtCodigoReferenciaProducto.Text) || string.IsNullOrEmpty(txtPrecioCompraProducto.Text) || string.IsNullOrEmpty(txtPrecioVenta.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtRutaImg.Text) || string.IsNullOrEmpty(txtDetalles.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Obj_Producto producto = new Obj_Producto();

                producto.IdProducto = idProducto;
                producto.Nombre = txtNombreProducto.Text;
                producto.Codigo = txtCodigoReferenciaProducto.Text;
                producto.PrecioCompra = int.Parse(txtPrecioCompraProducto.Text);
                producto.PrecioVenta = int.Parse(txtPrecioVenta.Text);
                producto.CantidadStock = int.Parse(txtCantidad.Text);
                producto.RutaFoto = txtRutaImg.Text;
                producto.Detalle = txtDetalles.Text;
                producto.IdCategoria = database.GetCategoriaProductoId(txtCategoriaProducto.Text).IdCategoriaProducto;

                var respuesta = database.UpdateProducto(producto);

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


        private void mostrarOpciones()
        {
            var listCategoria = database.GetCategoriaProductoList();

            foreach (var categoria_Producto in listCategoria)
            {
                txtCategoriaProducto.Items.Add(categoria_Producto.Descripcion);
            }
        }
    }
}
