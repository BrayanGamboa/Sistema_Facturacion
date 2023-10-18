﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_De_Negocios;

namespace Sistema_Facturacion
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }


        private void btn_send_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioLogin.Text) || string.IsNullOrEmpty(txtPasswordLogin.Text))
            {
                MessageBox.Show("Faltan campos por ingresar", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obj_Login login = new Obj_Login();
                login.Usuario = txtUsuarioLogin.Text;
                login.Contrasena = txtPasswordLogin.Text;              

                var respuestaValidacion = login.ValidarCredenciales(login);
                if (respuestaValidacion == 1)
                {
                    var nombreUsuario = login.GetNombre(login.Usuario);

                    Form_Inicio form1 = new Form_Inicio();
                    form1.Show();
                    this.Hide();
                    MessageBox.Show($"Bienvenido usuario: {nombreUsuario.Nombre}", "Credenciales correctas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no registrado en la BD", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            

           

        }

        
    }
}
