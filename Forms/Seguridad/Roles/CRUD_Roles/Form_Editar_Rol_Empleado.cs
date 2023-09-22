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

namespace Sistema_Facturacion.Forms.Seguridad
{
    public partial class Form_Editar_Rol_Empleado : MaterialForm
    {
        public Form_Editar_Rol_Empleado()
        {
            InitializeComponent();
        }
        private int idRol;

        public int IdRol { get => idRol; set => idRol = value; }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Rol_Empleado_Load(object sender, EventArgs e)
        {
            lblIdRol.Text = $"ID: {idRol.ToString()}";
            txtRol.Text = "Rol 1";
            txtDescripcionRol.Text = "Lorem ipsum dolor sit amet consectetur adipiscing elit turpis, proin class facilisi vitae fusce conubia auctor consequat curabitur, sociis placerat neque sem ac sociosqu cras.";
        }
    }
}
