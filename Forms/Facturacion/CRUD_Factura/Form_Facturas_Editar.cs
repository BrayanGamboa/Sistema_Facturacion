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
    public partial class Form_Facturas_Editar : MaterialForm
    {
        public Form_Facturas_Editar()
        {
            InitializeComponent();
        }

        private int idFactura;

        public int IdFactura { get => idFactura; set => idFactura = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
