using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_InterfazBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            // Mostramos el saludo con el nombre completo.
            lblResultado.Text = "Hola, " + nombre + " " + apellido + " ¡bienvenido!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtenemos la edad ingresada.
            string textoEdad = txtEdad.Text;

            // Verificamos que la edad sea un número válido.
            if (int.TryParse(textoEdad, out int edad) && edad >= 0)
            {
                // Determinamos si la persona es mayor o menor de edad.
                if (edad >= 18)
                {
                    if (rdbMasculino.Checked)
                    {
                        lblMensaje.Text = "Eres un hombre mayor de edad.";
                    }
                    else if (rdbFemenino.Checked)
                    {
                        lblMensaje.Text = "Eres una mujer mayor de edad.";
                    }
                    else
                    {
                        lblMensaje.Text = "Eres mayor de edad.";
                    }
                }
                else
                {
                    if (rdbMasculino.Checked)
                    {
                        lblMensaje.Text = "Eres un hombre menor de edad.";
                    }
                    else if (rdbFemenino.Checked)
                    {
                        lblMensaje.Text = "Eres una mujer menor de edad.";
                    }
                    else
                    {
                        lblMensaje.Text = "Eres menor de edad.";
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese una edad válida.";
            }

            // Convertimos el mensaje a mayúsculas si la casilla está marcada.
            if (chkMayus.Checked)
            {
                lblMensaje.Text = lblMensaje.Text.ToUpper();
            }
        }
    }
}
