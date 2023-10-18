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
using Capa_Logica_De_Negocios.Class.Facturacion;
using Capa_Logica_De_Negocios.Class;

namespace Sistema_Facturacion.Forms.Facturacion.CRUD_Factura
{
    public partial class Form_Factura_Nuevo : MaterialForm
    {
        public Form_Factura_Nuevo()
        {
            InitializeComponent();
        }

        private int idFactura;


        public int IdFactura { get => idFactura; set => idFactura = value; }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtNombreEmpleado.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtIva.Text) || string.IsNullOrEmpty(valorTotal.Text) || string.IsNullOrEmpty(fechaFactura.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtDetalles.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Cliente obj_Cliente = new Obj_Cliente();
                Obj_Empleado obj_empleado = new Obj_Empleado();
                Obj_Estado_Factura obj_Estado_Factura = new Obj_Estado_Factura();

                var idEmpleado = obj_empleado.GetEmpleadoId(txtNombreEmpleado.Text);
                var idCliente = obj_Cliente.GetClienteId(txtNombreCliente.Text);
                var idEstado = obj_Estado_Factura.GetEstadoFacturaId(txtEstado.Text);


                Obj_Factura factura = new Obj_Factura();
                factura.IdEmpleado = idEmpleado.IdEmpleado;
                factura.IdCliente = idCliente.IdCliente;
                factura.Descuento = int.Parse(txtDescuento.Text);
                factura.Impuesto = int.Parse(txtIva.Text);
                factura.ValorTotal = int.Parse(valorTotal.Text);
                factura.DateTime = DateTime.Parse(fechaFactura.Text);
                factura.IdEstado = idEstado.IdEstado;
                factura.Descripcion = txtDetalles.Text;

                var newFactura = factura.New_Factura(factura);

                if (newFactura == 1)
                {
                    MessageBox.Show("Factura guardada con exito", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron en la base de datos", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void img_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarOpciones()
        {
            Obj_Cliente obj_Cliente = new Obj_Cliente();
            Obj_Empleado obj_empleado = new Obj_Empleado();
            Obj_Estado_Factura obj_Estado_Factura = new Obj_Estado_Factura();

            var listClientes = obj_Cliente.GetClienteList();
            var listEmpleados = obj_empleado.GetEmpleadosList();
            var listEstadoFactura = obj_Estado_Factura.GetEstadoFacturaList();

            foreach (var cliente in listClientes)
            {
                txtNombreCliente.Items.Add(cliente.Nombre);
            }

            foreach (var empleado in listEmpleados)
            {
                txtNombreEmpleado.Items.Add(empleado.Nombre);
            }

            foreach (var estado_factura in listEstadoFactura)
            {
                txtEstado.Items.Add(estado_factura.Descripcion);
            }
        }

        private void Form_Factura_Nuevo_Load(object sender, EventArgs e)
        {
            mostrarOpciones();
        }
    }
}
