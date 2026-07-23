using System;
using System.Data;
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
            // Si tu metodo es static, se llama así directo
            dgvPacientes.DataSource = Paciente.visualizarPacientes();

            // Si NO es static, es así:
            // Paciente obj = new Paciente();
            // dgvPacientes.DataSource = obj.visualizarPacientes();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AgregarPaciente frmAgregar = new AgregarPaciente();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                CargarDatos(); // Recargas con el mismo método
            }
        }
    }
}