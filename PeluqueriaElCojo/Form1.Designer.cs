namespace PeluqueriaElCojo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnVerRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.SuspendLayout();

            this.txtNombre.Location = new System.Drawing.Point(172, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);

            this.txtTelefono.Location = new System.Drawing.Point(444, 54);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);

            this.btnAgregarCliente.Location = new System.Drawing.Point(424, 142);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);

            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(424, 182);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(325, 84);
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);

            this.chkCorteNormal.Location = new System.Drawing.Point(173, 101);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(200, 20);
            this.chkCorteNormal.Text = "Corte Normal (RD$300)";

            this.chkDegradado.Location = new System.Drawing.Point(173, 264);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Text = "Degradado";

            this.numNivel.Location = new System.Drawing.Point(280, 263);
            this.numNivel.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numNivel.Name = "numNivel";

            this.chkAfeitado.Location = new System.Drawing.Point(173, 145);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Text = "Afeitado (RD$250)";

            this.chkToalla.Location = new System.Drawing.Point(173, 182);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Text = "+ Toalla (+RD$50)";

            this.chkCejas.Location = new System.Drawing.Point(173, 223);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Text = "Cejas (RD$150)";

            this.btnCobrar.Location = new System.Drawing.Point(424, 292);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(120, 40);
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);

            this.txtRecibo.Location = new System.Drawing.Point(12, 400);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(776, 150);
            this.txtRecibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            this.lblTotal.Location = new System.Drawing.Point(560, 300);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "TOTAL: RD$0";

            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 20);
            this.lblStatus.Text = "Iniciando...";

            this.btnBackup.Location = new System.Drawing.Point(12, 350);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(130, 30);
            this.btnBackup.Text = "Generar Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);

            this.btnVerRanking.Location = new System.Drawing.Point(160, 350);
            this.btnVerRanking.Name = "btnVerRanking";
            this.btnVerRanking.Size = new System.Drawing.Size(130, 30);
            this.btnVerRanking.Text = "Ver Ranking";
            this.btnVerRanking.Click += new System.EventHandler(this.btnVerRanking_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btnVerRanking);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.chkCejas);
            this.Controls.Add(this.chkToalla);
            this.Controls.Add(this.chkAfeitado);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.chkDegradado);
            this.Controls.Add(this.chkCorteNormal);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Peluqueria El Cojo - Gestión Pro";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnVerRanking;
    }
}