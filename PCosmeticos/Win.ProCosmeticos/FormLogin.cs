﻿using BL.Cosmeticos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ProCosmeticos
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();

        }
        
        private void Login()
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verificando.....";
            Application.DoEvents();



            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado != null)

            {
                Utilidades.NombreUsuario = resultado.Nombre;
                this.Close();
                MessageBox.Show("Bienvenidos a Cosmeticos Zare");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta, Ingrese los datos nuevamente");
            }
            button1.Enabled = true;
            button1.Text = "Aceptar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
