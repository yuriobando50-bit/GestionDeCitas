namespace GestionDeCitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroClientes formulario = new FormRegistroClientes();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultarCitas ventanaConsultas = new FormConsultarCitas();
            ventanaConsultas.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar que la caja de texto no esté vacía
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del paciente que desea buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar el nombre que se escribió
            string pacienteABuscar = textBox1.Text.Trim();

            // Abrir la ventana de consultas de citas
            FormConsultarCitas ventanaConsultas = new FormConsultarCitas();
            ventanaConsultas.ShowDialog();
        }
    }
}
