using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Forms.Facturacion
{
    public partial class Form_Informe : Form
    {
        public Form_Informe()
        {
            InitializeComponent();
        }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
