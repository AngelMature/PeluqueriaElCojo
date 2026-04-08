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
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.Navy;
            this.btnAdmin.Location = new System.Drawing.Point(50, 90);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(250, 45);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ACCESO ADMINISTRADOR";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            this.btnBarbero.BackColor = System.Drawing.Color.White;
            this.btnBarbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarbero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBarbero.ForeColor = System.Drawing.Color.Crimson;
            this.btnBarbero.Location = new System.Drawing.Point(50, 150);
            this.btnBarbero.Name = "btnBarbero";
            this.btnBarbero.Size = new System.Drawing.Size(250, 45);
            this.btnBarbero.TabIndex = 2;
            this.btnBarbero.Text = "ENTRAR COMO BARBERO";
            this.btnBarbero.UseVisualStyleBackColor = false;
            this.btnBarbero.Click += new System.EventHandler(this.btnBarbero_Click);

            this.btnSalirLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalirLogin.ForeColor = System.Drawing.Color.White;
            this.btnSalirLogin.Location = new System.Drawing.Point(50, 230);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(250, 40);
            this.btnSalirLogin.TabIndex = 4;
            this.btnSalirLogin.Text = "SALIR DEL SISTEMA";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "SISTEMA DE GESTIÓN";

            this.pnlTop.BackColor = System.Drawing.Color.Crimson;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(350, 15);
            this.pnlTop.TabIndex = 0;

            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBarbero);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - El Cojo 2024-2048";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBarbero;
        private System.Windows.Forms.Button btnSalirLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTop;
    }
}