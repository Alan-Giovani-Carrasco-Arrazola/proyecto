using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Principal : Form
    {
        private Form formularioActivo = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pacientes());
        }
        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Recepción());
        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false; // Indispensable
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear(); // Limpia el panel grande
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        
    }
}
