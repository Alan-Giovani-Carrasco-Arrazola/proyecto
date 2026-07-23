namespace Integrador
{
    partial class Principal
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnPacientes = new Button();
            panelContenedor = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 50);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnPacientes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 471);
            panel2.TabIndex = 1;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(30, 123);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(94, 29);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(767, 471);
            panelContenedor.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(30, 88);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Recepción";
            button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 521);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Principal";
            Text = "Principal";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelContenedor;
        private Button btnPacientes;
        private Button button1;
    }
}