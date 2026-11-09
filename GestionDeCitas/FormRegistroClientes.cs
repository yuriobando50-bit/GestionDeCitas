using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDeCitas
{
    public partial class FormRegistroClientes : Form
    {
        public class Cliente
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
        }

        public static List<Cliente> listaClientes = new List<Cliente>();

        public FormRegistroClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente nuevoCliente = new Cliente()
            {
                Nombre = textBox1.Text,
                Telefono = textBox2.Text,
                Correo = textBox3.Text
            };

            listaClientes.Add(nuevoCliente);

            MessageBox.Show("¡Cliente registrado con éxito en memoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

            // Si quieres que además de registrar se cierre la ventana automáticamente, 
            // puedes descomentar la siguiente línea borrando las dos barras (//):
            // this.Close();
        }
    }
}