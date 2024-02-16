using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_de_Escritorio
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public void validarLasCheckBox()
        {
            
            if (textBoxApellido.Text == "")
                labelApellidoBack.BackColor = Color.Red;
            else labelApellidoBack.BackColor = SystemColors.AppWorkspace;

            if (textBoxNombre.Text == "")
                labelNombreBack.BackColor = Color.Red;
            else labelNombreBack.BackColor = SystemColors.AppWorkspace;

            if (textBoxEdad.Text == "")
                labelEdadBack.BackColor = Color.Red;
            else labelEdadBack.BackColor = SystemColors.AppWorkspace;

            if (textBoxDireccion.Text == "")
                labelDireccionBack.BackColor = Color.Red;
            else labelDireccionBack.BackColor = SystemColors.AppWorkspace;

        }

        public void imprimirResultados()
        {
            if (textBoxApellido.Text == "" || textBoxNombre.Text == "" ||
                textBoxEdad.Text == "" || textBoxDireccion.Text == "")
                MessageBox.Show("Por favor ingrese los datos solicitados", "Atención");
            else textBoxResultado.Text = "Apellido y Nombre: " + textBoxApellido.Text + " " +
                    textBoxNombre.Text + "\r\nEdad: " + textBoxEdad.Text +
                    "\r\nDirección: " + textBoxDireccion.Text;
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.validarLasCheckBox();
            this.imprimirResultados();          
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
