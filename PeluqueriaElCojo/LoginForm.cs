using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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

            if (password == "admin")
            {
                this.Hide();

                using (Form1 principal = new Form1(true))
                {
                    principal.ShowDialog();
                }

                // Esta es la clave: solo muestra el login si no se ha cerrado la App
                if (!this.IsDisposed && !Application.MessageLoop == false)
                {
                    this.Show();
                }
            }
            else if (!string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Contraseña incorrecta. Acceso denegado.", "Error");
            }
        }

        private void btnBarbero_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form1 principal = new Form1(false))
            {
                principal.ShowDialog();
            }

            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}