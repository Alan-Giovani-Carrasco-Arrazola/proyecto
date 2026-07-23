using System;
using System.Windows.Forms;
// BORRA ESTA LÍNEA: using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Integrador
{
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void btnAgregarPac_Click(object sender, EventArgs e)
        {
            try
            {
                int expediente = int.Parse(textBox4.Text);
                string nombre = textBox1.Text;
                string apellidoP = textBox2.Text;
                string apellidoM = textBox3.Text;
                DateTime fechaNac = dateTimePicker1.Value;
                string genero = comboBox1.Text;
                string estadoCivil = comboBox2.Text;
                string curp = textBox5.Text;
                string tipoSangre = comboBox3.Text;
                string domicilio = textBox7.Text;
                string telefonoCorreo = textBox6.Text;

                Paciente.registraPacientes(expediente, nombre, apellidoP, apellidoM, fechaNac, genero, estadoCivil, curp, tipoSangre, domicilio, telefonoCorreo);

                MessageBox.Show("Paciente registrado correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}