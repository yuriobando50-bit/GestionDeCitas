using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestionDeCitas.FormRegistroClientes;

namespace GestionDeCitas
{
    public partial class FormConsultarCitas : Form
    {
        public FormConsultarCitas()
        {
            InitializeComponent();
            // Vinculamos el evento de carga y el botón
            this.Load += new EventHandler(FormConsultarCitas_Load);
            this.button1.Click += new EventHandler(buttonCancelar_Click);
        }

        private void FormConsultarCitas_Load(object sender, EventArgs e)
        {
            // Cargamos la lista estática que tenemos en memoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FormRegistroClientes.listaClientes;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenemos el cliente seleccionado en la tabla
                Cliente clienteSeleccionado = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                // Lo eliminamos de la lista en memoria
                FormRegistroClientes.listaClientes.Remove(clienteSeleccionado);

                // Actualizamos la tabla para que refleje el cambio
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FormRegistroClientes.listaClientes;

                MessageBox.Show("Cita cancelada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa de la tabla para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}