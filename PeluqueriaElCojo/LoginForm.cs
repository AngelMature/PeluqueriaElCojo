using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Necesario para el Interaction.InputBox

namespace PeluqueriaElCojo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("Ingrese la contraseña de Administrador:", "Verificación de Seguridad", "");

            if (password == "1234")
            {
                this.Hide();
                Form1 principal = new Form1(true);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Acceso denegado.", "Error");
            }
        }

        private void btnBarbero_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1(false);
            principal.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}