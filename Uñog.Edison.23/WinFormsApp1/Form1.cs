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

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMedicos.SelectedItem != null)
            {
                PersonalMedico personalMedico = this.lstMedicos.SelectedItem as PersonalMedico;

                if (personalMedico is not null)
                {
                    this.richMedicoPaciente.Text = Persona.FichaPersonal(personalMedico);
                }
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (this.lstMedicos.SelectedItems != null && this.lstPacientes.SelectedItems != null)
            {
                PersonalMedico personalMedico = lstMedicos.SelectedItem as PersonalMedico;
                Paciente paciente = lstPacientes.SelectedItem as Paciente;

                if (personalMedico is not null && paciente is not null)
                {
                    Consulta consulta = personalMedico + paciente;

                    if (consulta is not null)
                    {
                        paciente.Diagnostico = "Curado";

                        MessageBox.Show($"{consulta.ToString()}", "Atenci�n finalizada", MessageBoxButtons.OK);

                        this.richMedicoPaciente.Text = Persona.FichaPersonal(personalMedico);
                        this.lstMedicos.SelectedItem = null;
                        this.lstPacientes.SelectedItem = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("�Seguro desea salir?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
