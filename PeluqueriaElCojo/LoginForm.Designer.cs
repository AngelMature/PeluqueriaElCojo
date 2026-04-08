namespace PeluqueriaElCojo
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBarbero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.Text = "Seleccione su Rol de Acceso";
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.AutoSize = true;

            this.btnAdmin.Text = "Entrar como Administrador";
            this.btnAdmin.Location = new System.Drawing.Point(50, 70);
            this.btnAdmin.Size = new System.Drawing.Size(200, 40);
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            this.btnBarbero.Text = "Entrar como Barbero";
            this.btnBarbero.Location = new System.Drawing.Point(50, 120);
            this.btnBarbero.Size = new System.Drawing.Size(200, 40);
            this.btnBarbero.Click += new System.EventHandler(this.btnBarbero_Click);

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBarbero);
            this.Controls.Add(this.label1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Peluquería El Cojo";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBarbero;
        private System.Windows.Forms.Label label1;
    }
}