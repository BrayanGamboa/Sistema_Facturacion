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
            lblIdCategoria.Text = $"ID: {idCategoria.ToString()}";
            txtCategoria.Text = "Categoria 1";
        }
    }
}
