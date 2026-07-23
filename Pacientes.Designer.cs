namespace Integrador
{
    partial class Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPacientes = new DataGridView();
            btnNuevoPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(104, 106);
            dgvPacientes.Name = "dataGridView1";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(612, 270);
            dgvPacientes.TabIndex = 0;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Location = new Point(549, 62);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(167, 29);
            btnNuevoPaciente.TabIndex = 1;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = true;
            btnNuevoPaciente.Click += Button1_Click;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(dgvPacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pacientes";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
        private Button btnNuevoPaciente;
    }
}