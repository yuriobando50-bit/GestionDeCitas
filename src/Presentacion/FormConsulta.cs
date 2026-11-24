using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDeCitas
{
    public partial class FormConsulta : Form
    {
        private List<Cliente> pacientes = new List<Cliente>();
        public FormConsulta()
        {
            InitializeComponent();
            pacientes.Add(new Cliente { Nombre = "María López", Telefono = "8888-1111", Correo = "maria@gmail.com" });
            pacientes.Add(new Cliente { Nombre = "Pedro Ramírez", Telefono = "8888-2222", Correo = "pedro@gmail.com" });

            dgvPacientes.DataSource = pacientes;
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
public class Cliente
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
}