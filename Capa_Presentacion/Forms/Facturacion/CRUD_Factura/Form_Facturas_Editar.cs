using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using Capa_Logica_De_Negocios;
using Capa_Logica_De_Negocios.Class.Facturacion;
using Capa_Logica_De_Negocios.Class.Tablas;
using Capa_Logica_De_Negocios.Class;

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

        private void Form_Facturas_Editar_Load(object sender, EventArgs e)
        {
            Obj_Factura obj_Factura = new Obj_Factura();
            var datosFactura = obj_Factura.GetFacturaForId(IdFactura);

            txtIdFactura.Text = idFactura.ToString();
            txtDescuento.Text = datosFactura.Descuento.ToString();
            txtIva.Text = datosFactura.Impuesto.ToString();
            detalles.Text = datosFactura.Descripcion;

            mostrarOpciones();
            txtEstado.SelectedItem = datosFactura.Estado;
            txtNombreEmpleado.SelectedItem = datosFactura.NombreEmpleado;
            txtNombreCliente.SelectedItem = datosFactura.NombreCliente;
            lblValorTotal.Text = datosFactura.ValorTotal.ToString();
        }

        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtIva.Text) || string.IsNullOrEmpty(lblValorTotal.Text) || string.IsNullOrEmpty(detalles.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtNombreEmpleado.Text) || string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Estado_Factura obj_Estado_Factura = new Obj_Estado_Factura();
                Obj_Factura obj_Factura = new Obj_Factura();
                Obj_Empleado obj_empleado = new Obj_Empleado();
                Obj_Cliente obj_Cliente = new Obj_Cliente();
                obj_Factura.IdFactura = idFactura;
                obj_Factura.Descuento = int.Parse(txtDescuento.Text);
                obj_Factura.Impuesto = int.Parse(txtIva.Text);
                obj_Factura.ValorTotal = int.Parse(lblValorTotal.Text);
                obj_Factura.Descripcion = detalles.Text;
                obj_Factura.IdEstado = obj_Estado_Factura.GetEstadoFacturaId(txtEstado.Text).IdEstado;
                obj_Factura.IdCliente = obj_Cliente.GetClienteId(txtNombreCliente.Text).IdCliente;
                obj_Factura.IdEmpleado = obj_empleado.GetEmpleadoId(txtNombreEmpleado.Text).IdEmpleado;

                var respuesta = obj_Factura.UpdateFactura(obj_Factura);
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
            Obj_Cliente obj_Cliente = new Obj_Cliente();
            Obj_Empleado Obj_Empleado = new Obj_Empleado();
            Obj_Estado_Factura obj_Estado_Factura = new Obj_Estado_Factura();
            

            var listClientes = obj_Cliente.GetClienteList();
            var listEmpleado = Obj_Empleado.GetEmpleadosList();
            var listEstadoFactura = obj_Estado_Factura.GetEstadoFacturaList();

            foreach (var cliente in listClientes)
            {
                txtNombreCliente.Items.Add(cliente.Nombre);
            }
            foreach (var empleado in listEmpleado)
            {
                txtNombreEmpleado.Items.Add(empleado.Nombre);
            }
            foreach (var estado_Factura in listEstadoFactura)
            {
                txtEstado.Items.Add(estado_Factura.Descripcion);
            }
        }
    }
}
