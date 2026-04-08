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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.lblNivel = new System.Windows.Forms.Label();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnVerRanking = new System.Windows.Forms.Button();
            this.grpServicios = new System.Windows.Forms.GroupBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.grpServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 45);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 16);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nombre:";

            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(250, 45);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(64, 16);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Teléfono:";

            this.txtNombre.Location = new System.Drawing.Point(85, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 11;

            this.txtTelefono.Location = new System.Drawing.Point(320, 42);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 22);
            this.txtTelefono.TabIndex = 9;

            this.btnAgregarCliente.Location = new System.Drawing.Point(460, 38);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarCliente.TabIndex = 8;
            this.btnAgregarCliente.Text = "Registrar";
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);

            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(580, 40);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(200, 100);
            this.lstClientes.TabIndex = 7;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);

            this.chkCorteNormal.AutoSize = true;
            this.chkCorteNormal.Location = new System.Drawing.Point(15, 30);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(166, 20);
            this.chkCorteNormal.TabIndex = 0;
            this.chkCorteNormal.Text = "Corte Normal - RD$300";

            this.chkDegradado.AutoSize = true;
            this.chkDegradado.Location = new System.Drawing.Point(15, 137);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(157, 20);
            this.chkDegradado.TabIndex = 4;
            this.chkDegradado.Text = "Degradado - RD$450";

            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(15, 162);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(127, 16);
            this.lblNivel.TabIndex = 16;
            this.lblNivel.Text = "Nivel de Degradado:";

            this.numNivel.Location = new System.Drawing.Point(15, 180);
            this.numNivel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(120, 22);
            this.numNivel.TabIndex = 5;
            this.numNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNivel.ValueChanged += new System.EventHandler(this.numNivel_ValueChanged);

            this.chkAfeitado.AutoSize = true;
            this.chkAfeitado.Location = new System.Drawing.Point(15, 56);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(137, 20);
            this.chkAfeitado.TabIndex = 1;
            this.chkAfeitado.Text = "Afeitado - RD$250";

            this.chkCejas.AutoSize = true;
            this.chkCejas.Location = new System.Drawing.Point(15, 111);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(122, 20);
            this.chkCejas.TabIndex = 3;
            this.chkCejas.Text = "Cejas - RD$150";

            this.btnCobrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCobrar.Location = new System.Drawing.Point(360, 100);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(180, 50);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "GENERAR COBRO";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);

            this.txtRecibo.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtRecibo.Location = new System.Drawing.Point(360, 170);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.Size = new System.Drawing.Size(420, 280);
            this.txtRecibo.TabIndex = 4;

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(360, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(173, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL: RD$ 0.00";

            this.lblStatus.Location = new System.Drawing.Point(20, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 2;

            this.btnBackup.Location = new System.Drawing.Point(20, 470);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(140, 35);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Generar Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);

            this.btnVerRanking.Location = new System.Drawing.Point(170, 470);
            this.btnVerRanking.Name = "btnVerRanking";
            this.btnVerRanking.Size = new System.Drawing.Size(140, 35);
            this.btnVerRanking.TabIndex = 0;
            this.btnVerRanking.Text = "Ver Ranking";
            this.btnVerRanking.Click += new System.EventHandler(this.btnVerRanking_Click);

            this.grpServicios.Controls.Add(this.chkCorteNormal);
            this.grpServicios.Controls.Add(this.chkAfeitado);
            this.grpServicios.Controls.Add(this.chkToalla);
            this.grpServicios.Controls.Add(this.chkCejas);
            this.grpServicios.Controls.Add(this.chkDegradado);
            this.grpServicios.Controls.Add(this.lblNivel);
            this.grpServicios.Controls.Add(this.numNivel);
            this.grpServicios.Location = new System.Drawing.Point(20, 85);
            this.grpServicios.Name = "grpServicios";
            this.grpServicios.Size = new System.Drawing.Size(320, 220);
            this.grpServicios.TabIndex = 6;
            this.grpServicios.TabStop = false;
            this.grpServicios.Text = "Servicios y Precios";

            this.chkToalla.AutoSize = true;
            this.chkToalla.Location = new System.Drawing.Point(15, 85);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(171, 20);
            this.chkToalla.TabIndex = 2;
            this.chkToalla.Text = "Toalla Caliente - RD$50";
            this.chkToalla.CheckedChanged += new System.EventHandler(this.chkToalla_CheckedChanged);

            this.dateTimePicker1.Location = new System.Drawing.Point(85, 428);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;

            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVerRanking);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.grpServicios);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Peluquería El Cojo - Sistema de Gestión";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.grpServicios.ResumeLayout(false);
            this.grpServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.GroupBox grpServicios;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnVerRanking;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}