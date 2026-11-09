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
    }
}
