using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Pacientes : Form
    {
        
        public Pacientes()
        {
            InitializeComponent();
        }
        private void Pacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        void CargarDatos()
        {
            Paciente obj = new Paciente();
            dataGridView1.DataSource = obj.visualizarPacientes();
        }
    }
}
