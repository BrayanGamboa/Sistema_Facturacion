using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Facturacion.Class;
using Sistema_Facturacion.Class.Objetos;

namespace Sistema_Facturacion.Forms.Cliente
{
    public partial class Form_Editar_Clientes : MaterialForm
    {
        public Form_Editar_Clientes()
        {
            InitializeComponent();
        }

        ConnectionDB database = new ConnectionDB();

        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        private void Form_Editar_Clientes_Load(object sender, EventArgs e)
        {
            var datosCliente = database.GetClienteForId(idCliente);

            lbl_id_usuario.Text = $"ID: {idCliente}";
            txt_nombre_actualizar.Text = datosCliente.Nombre;
            txt_documento_actualizar.Text = datosCliente.Documento.ToString();
            txt_email_actualizar.Text = datosCliente.Email;
            txt_telefono_actualizar.Text = datosCliente.Telefono;
        }

        private void btn_actualizar_usuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre_actualizar.Text) || string.IsNullOrEmpty(txt_documento_actualizar.Text) || string.IsNullOrEmpty(txt_email_actualizar.Text) || string.IsNullOrEmpty(txt_telefono_actualizar.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Cliente cliente = new Obj_Cliente();
                cliente.IdCliente = idCliente;
                cliente.Nombre = txt_nombre_actualizar.Text;
                cliente.Documento = int.Parse(txt_documento_actualizar.Text);
                cliente.Email = txt_email_actualizar.Text;
                cliente.Telefono = txt_telefono_actualizar.Text;

                if (database.UpdateCliente(cliente) == 1)
                {
                    MessageBox.Show("Datos actualizados en la BD", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualiozar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }


            
        }

        private void img_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
