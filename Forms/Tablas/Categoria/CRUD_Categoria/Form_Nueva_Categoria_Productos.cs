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
    public partial class Form_Nueva_Categoria_Productos : MaterialForm
    {
        public Form_Nueva_Categoria_Productos()
        {
            InitializeComponent();
        }

        ConnectionDB dataBase = new ConnectionDB();

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Categoria_Producto categoria_Producto = new Obj_Categoria_Producto();
                
                categoria_Producto.Descripcion = txtCategoria.Text;


                var newUsuario = dataBase.New_Categoria_Producto(categoria_Producto);

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
