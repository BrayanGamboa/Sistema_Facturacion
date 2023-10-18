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
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class.Tablas;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Editar_Productos : MaterialForm
    {
        public Form_Editar_Productos()
        {
            InitializeComponent();
        }        

        private int idProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Editar_Productos_Load(object sender, EventArgs e)
        {
            Obj_Producto obj_Producto = new Obj_Producto();
            var datosEmpleado = obj_Producto.GetProductoForId(IdProducto);            

            lblIdProducto.Text = $"ID: {idProducto}";
            txtNombreProducto.Text = datosEmpleado.Nombre;
            txtCodigoReferenciaProducto.Text = datosEmpleado.Codigo;
            txtPrecioCompraProducto.Text = datosEmpleado.PrecioCompra.ToString();
            txtPrecioVenta.Text = datosEmpleado.PrecioVenta.ToString();
            txtCantidad.Text = datosEmpleado.CantidadStock.ToString();            
            txtRutaImg.Text = datosEmpleado.RutaFoto;
            txtDetalles.Text = datosEmpleado.Detalle;

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
                Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();

                producto.IdProducto = idProducto;
                producto.Nombre = txtNombreProducto.Text;
                producto.Codigo = txtCodigoReferenciaProducto.Text;
                producto.PrecioCompra = int.Parse(txtPrecioCompraProducto.Text);
                producto.PrecioVenta = int.Parse(txtPrecioVenta.Text);
                producto.CantidadStock = int.Parse(txtCantidad.Text);
                producto.RutaFoto = txtRutaImg.Text;
                producto.Detalle = txtDetalles.Text;
                producto.IdCategoria = obj_Categoria_Producto.GetCategoriaProductoId(txtCategoriaProducto.Text).IdCategoriaProducto;
            
                var respuesta = producto.UpdateProducto(producto);                    

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
            Obj_Categoria_Producto obj_Categoria_Producto = new Obj_Categoria_Producto();

            var listCategoria = obj_Categoria_Producto.GetCategoriaProductoList();

            foreach (var categoria_Producto in listCategoria)
            {
                txtCategoriaProducto.Items.Add(categoria_Producto.Descripcion);
            }
        }
    }
}
