using Entidades;

namespace WinFormsApp1
{
    public partial class FrmAtencion : Form
    {
        private Consulta consulta;
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            PersonalMedico personalMedico = lstMedicos.SelectedItem as PersonalMedico;
            Paciente paciente = lstPacientes.SelectedItem as Paciente;

            
            if (personalMedico is not null)
            {
                if (personalMedico + paciente)
                {
                    // , consulta.Fecha, paciente.ToString()
                    MessageBox.Show($"Fecha:  atendio a: {paciente.ToString()}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    richMedicoPaciente.Text = personalMedico.FichaExtra();
                }
                else
                {
                    MessageBox.Show("No hay consultas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
