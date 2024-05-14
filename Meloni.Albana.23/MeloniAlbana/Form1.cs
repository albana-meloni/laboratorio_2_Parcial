using ClassLibrary;
using System.Security.Cryptography;

namespace MeloniAlbana
{
    public partial class FormAtencion : Form
    {
        public FormAtencion()
        {
            InitializeComponent();
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));

            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            PersonalMedico medico = (PersonalMedico)lstMedicos.SelectedItem;
            Paciente paciente = (Paciente)lstPacientes.SelectedItem;

            if (medico is not null && paciente is not null)
            {
                Consulta nuevaConsulta = medico + paciente;
                paciente.Diagnostico = "Paciente curado";

                lstMedicos.ClearSelected();
                lstPacientes.ClearSelected();
                rtbInfoMedico.Clear();

                MessageBox.Show(nuevaConsulta.ToString(), "Atención finalizada", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico medico = (PersonalMedico)lstMedicos.SelectedItem;

            if (medico is not null)
            {
                rtbInfoMedico.Text = medico.FichaPersonal(medico);
            }
        }

        private void FormAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
