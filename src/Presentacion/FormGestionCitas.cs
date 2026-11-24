using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDeCitas
{
    public partial class FormGestionCitas : Form
    {
        private List<string> citas = new List<string>();
        public FormGestionCitas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            string nombre = txtPaciente.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string motivo = txtMotivo.Text.Trim();
            string fecha = dtpFecha.Value.ToShortDateString();
            string hora = dtpHora.Value.ToShortTimeString();

            if (nombre == "" || telefono == "" || correo == "" || motivo == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{8,15}$"))
            {
                MessageBox.Show("El teléfono debe contener entre 8 y 15 dígitos.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }
            string nuevaCita = nombre + " | " + telefono + " | " + correo + " | " + fecha + " | " + hora + " | " + motivo;

            foreach (DataGridViewRow fila in dgvCitas.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells[3].Value.ToString() == fecha &&
                    fila.Cells[4].Value.ToString() == hora)
                {
                    MessageBox.Show("Ya existe una cita registrada en esa fecha y hora.");
                    return;
                }
            }
            citas.Add(nuevaCita);
            dgvCitas.Rows.Add(nombre, telefono, correo, fecha, hora, motivo);

            MessageBox.Show("Cita registrada correctamente.");
            txtPaciente.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtMotivo.Clear();

            txtPaciente.Focus();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
