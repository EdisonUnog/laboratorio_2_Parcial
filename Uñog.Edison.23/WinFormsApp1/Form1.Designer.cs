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
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 12);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(331, 259);
            lstMedicos.TabIndex = 0;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(362, 12);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(353, 259);
            lstPacientes.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(737, 427);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 86);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(737, 21);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(132, 112);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // richMedicoPaciente
            // 
            richMedicoPaciente.Location = new Point(12, 298);
            richMedicoPaciente.Name = "richMedicoPaciente";
            richMedicoPaciente.Size = new Size(694, 215);
            richMedicoPaciente.TabIndex = 4;
            richMedicoPaciente.Text = "";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 539);
            Controls.Add(richMedicoPaciente);
            Controls.Add(btnAtender);
            Controls.Add(btnSalir);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "FrmAtencion";
            Text = "Atencion de Pacientes";
            FormClosing += FrmAtencion_FormClosing;
            Load += FrmAtencion_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnSalir;
        private Button btnAtender;
        private RichTextBox richMedicoPaciente;
    }
}
