using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Integrador
{
    public partial class FormularioHoraLlegada : Form
    {
        public FormularioHoraLlegada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroLlegada registroLlegada = new RegistroLlegada();
        }
    }
}
