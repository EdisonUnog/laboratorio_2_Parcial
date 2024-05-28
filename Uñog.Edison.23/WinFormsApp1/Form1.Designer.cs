namespace WinFormsApp1
{
    partial class FrmAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            btnSalir = new Button();
            btnAtender = new Button();
            richMedicoPaciente = new RichTextBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 39);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(252, 214);
            lstMedicos.TabIndex = 0;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(280, 39);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(234, 214);
            lstPacientes.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(533, 402);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 86);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.FromArgb(128, 255, 255);
            btnAtender.FlatStyle = FlatStyle.Flat;
            btnAtender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtender.Location = new Point(533, 39);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(132, 112);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += btnAtender_Click;
            // 
            // richMedicoPaciente
            // 
            richMedicoPaciente.Location = new Point(12, 273);
            richMedicoPaciente.Name = "richMedicoPaciente";
            richMedicoPaciente.Size = new Size(502, 215);
            richMedicoPaciente.TabIndex = 4;
            richMedicoPaciente.Text = "";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicos.Location = new Point(12, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(98, 15);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacientes.Location = new Point(280, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(60, 15);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 507);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(richMedicoPaciente);
            Controls.Add(btnAtender);
            Controls.Add(btnSalir);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atencion de Pacientes";
            FormClosing += FrmAtencion_FormClosing;
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnSalir;
        private Button btnAtender;
        private RichTextBox richMedicoPaciente;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}
