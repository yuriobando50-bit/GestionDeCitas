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

            //Validar que teléfono contenga entre 8 y 15 dígitos.

            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono,@"^\d{8,15}$")) 

                {
                MessageBox.Show("El teléfono debe contener entre 8 y 15 dígitos");
                return;
                }

            //Validar que el formato del correo electrónico sea correcto.

            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s^]+\.[^@\s]+$")) 
            {
                MessageBox.Show("Correo inválido. Asegúrese de incluir @ y un dominio válido.");
                return;
            }

            // Aviso que se completo los datos solicitados.
            MessageBox.Show("Registro completado con éxito");
        }

    }
}
