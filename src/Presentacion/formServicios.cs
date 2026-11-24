using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDeCitas
{
    public partial class formServicios : Form
    {
        private List<Servicio> servicios = new List<Servicio>();

        public formServicios()
        {
            InitializeComponent();

            // Configuración de la tabla
            dgvServicios.ColumnCount = 3;

            dgvServicios.Columns[0].Name = "Nombre";
            dgvServicios.Columns[1].Name = "Descripción";
            dgvServicios.Columns[2].Name = "Precio";

            dgvServicios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Eventos de los botones
            btnRegistrarservicio.Click += btnRegistrarservicio_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        // Registrar un servicio
        private void btnRegistrarservicio_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string descripcion = textBox2.Text.Trim();
            string textoPrecio = textBox3.Text.Trim();

            if (nombre == "" || descripcion == "" || textoPrecio == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(textoPrecio, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que cero.");
                return;
            }

            Servicio nuevoServicio = new Servicio(
                nombre,
                descripcion,
                precio
            );

            servicios.Add(nuevoServicio);

            dgvServicios.Rows.Add(
                nuevoServicio.Nombre,
                nuevoServicio.Descripcion,
                nuevoServicio.Precio.ToString("0.00")
            );

            MessageBox.Show("Servicio registrado correctamente.");

            LimpiarCampos();
        }

        // Limpiar los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBox1.Focus();
        }
    }

    // Clase Servicio
    public class Servicio
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Servicio(string nombre, string descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
