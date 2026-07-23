using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Integrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            string usuario = txtUsuario.Text;
            string pass = txtPassword.Text;

            int existe = usu.verificarUsuario(usuario,pass);

            if (existe > 0)
            {
                Principal prin = new Principal();
                prin.Show();
                this.Hide();
            }
            else 
            { 
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
