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
        public FormRegistroClientes()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Se establece la variable para obtener la información requerida.
            string nombre = txtnombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            //Verificar que no exista campos vacíos.

            if (nombre == "" || telefono == "" || correo == "") 

                //Advertencia de campos vacíos, por lo tanto, no se puede continuar.
            {
                MessageBox.Show("Es necesario completar todos los campos");
                return;

            }
            // Aviso que se completo los datos solicitados.
            MessageBox.Show("Registro completado con éxito");
        }
    }
}
