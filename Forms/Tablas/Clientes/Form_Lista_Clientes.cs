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
using Sistema_Facturacion.Forms.Cliente;
using Sistema_Facturacion.Forms.Tablas.CRUD_Clientes;

namespace Sistema_Facturacion.Forms
{
    public partial class Form_Lista_Clientes : Form
    {

        ConnectionDB dataBase = new ConnectionDB();

        public Form_Lista_Clientes()
        {
            InitializeComponent();
        }

        private void mostrarUsuarios()
        {
            var listClientes = dataBase.GetClienteList();
            
                foreach (var cliente in listClientes)
                {
                    lstClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Documento, cliente.Telefono);
                }
            
        }

        private void Form_Lista_Clientes_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void btn_nuevo_usuario_Click_1(object sender, EventArgs e)
        {
            Form_Nuevo_Clientes nuevo_Cliente = new Form_Nuevo_Clientes();
            nuevo_Cliente.ShowDialog();
        }

        private void lst_clientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (lstClientes.Columns[e.ColumnIndex].Name == "btn_borrar")
            {                               
                string id_usuario = lstClientes.Rows[lstClientes.CurrentRow.Index].Cells["id_usuario"].Value.ToString();

                if (MessageBox.Show("¿Deseas borrar un cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataBase.DeleteClienteForId(int.Parse(id_usuario)) == 1)
                    {
                        MessageBox.Show($"Usuario eliminando  con el id: {id_usuario}", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Error al borrar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
            }
            else if (lstClientes.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int posActual = lstClientes.CurrentRow.Index;
                Form_Editar_Clientes clientes = new Form_Editar_Clientes();
                clientes.IdCliente = int.Parse(lstClientes[0, posActual].Value.ToString());
                clientes.ShowDialog();
            }
        }

        private void img_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre_usuario.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var cliente = dataBase.GetClienteId(txt_nombre_usuario.Text);
                lstClientes.Rows.Clear();
                lstClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Documento, cliente.Telefono);
            }

            
        }
    }
}
