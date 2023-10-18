using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class.Tablas;

namespace Sistema_Facturacion.Forms.Tablas.CRUD_Clientes
{
    public partial class Form_Nuevo_Clientes : MaterialForm
    {
        
        public Form_Nuevo_Clientes()
        {
            InitializeComponent();
        }        


        private void img_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_nuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_documento.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Cliente cliente = new Obj_Cliente();

                cliente.Nombre = txt_nombre.Text;
                cliente.Documento = int.Parse(txt_documento.Text);
                cliente.Telefono = txt_telefono.Text;
                cliente.Email = txt_email.Text;

                var newUsuario = cliente.New_Cliente(cliente);

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
