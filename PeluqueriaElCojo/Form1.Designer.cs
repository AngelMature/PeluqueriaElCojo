namespace PeluqueriaElCojo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbBarberos;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.GroupBox grpServicios;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnVerRanking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;

        // Nuevos controles para cumplir requerimientos técnicos
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGenerarReporte;

        // Control para selección física de productos
        private System.Windows.Forms.CheckedListBox clbProductos;
        private System.Windows.Forms.Label lblProdInv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbBarberos = new System.Windows.Forms.ComboBox();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.grpServicios = new System.Windows.Forms.GroupBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnVerRanking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.clbProductos = new System.Windows.Forms.CheckedListBox();
            this.lblProdInv = new System.Windows.Forms.Label();
            this.grpServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 45);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 16);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nombre:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(250, 45);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(64, 16);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 21;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(320, 42);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 22);
            this.txtTelefono.TabIndex = 19;
            // 
            // cmbBarberos
            // 
            this.cmbBarberos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarberos.Location = new System.Drawing.Point(85, 70);
            this.cmbBarberos.Name = "cmbBarberos";
            this.cmbBarberos.Size = new System.Drawing.Size(150, 24);
            this.cmbBarberos.TabIndex = 6;
            this.cmbBarberos.SelectedIndexChanged += new System.EventHandler(this.cmbBarberos_SelectedIndexChanged);
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.Location = new System.Drawing.Point(320, 70);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(120, 24);
            this.cmbTipoCliente.TabIndex = 7;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(460, 38);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarCliente.TabIndex = 18;
            this.btnAgregarCliente.Text = "Registrar";
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(580, 40);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(200, 100);
            this.lstClientes.TabIndex = 17;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // grpServicios
            // 
            this.grpServicios.Controls.Add(this.chkCorteNormal);
            this.grpServicios.Controls.Add(this.chkAfeitado);
            this.grpServicios.Controls.Add(this.chkToalla);
            this.grpServicios.Controls.Add(this.chkCejas);
            this.grpServicios.Controls.Add(this.chkDegradado);
            this.grpServicios.Controls.Add(this.lblNivel);
            this.grpServicios.Controls.Add(this.numNivel);
            this.grpServicios.Location = new System.Drawing.Point(20, 100);
            this.grpServicios.Name = "grpServicios";
            this.grpServicios.Size = new System.Drawing.Size(320, 215);
            this.grpServicios.TabIndex = 16;
            this.grpServicios.TabStop = false;
            this.grpServicios.Text = "Servicios y Precios";
            // 
            // chkCorteNormal
            // 
            this.chkCorteNormal.Location = new System.Drawing.Point(15, 25);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(166, 20);
            this.chkCorteNormal.TabIndex = 0;
            this.chkCorteNormal.Text = "Corte Normal - RD$300";
            // 
            // chkAfeitado
            // 
            this.chkAfeitado.Location = new System.Drawing.Point(15, 50);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(137, 20);
            this.chkAfeitado.TabIndex = 1;
            this.chkAfeitado.Text = "Afeitado - RD$250";
            // 
            // chkToalla
            // 
            this.chkToalla.Location = new System.Drawing.Point(15, 75);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(171, 20);
            this.chkToalla.TabIndex = 2;
            this.chkToalla.Text = "Toalla Caliente - RD$50";
            // 
            // chkCejas
            // 
            this.chkCejas.Location = new System.Drawing.Point(15, 100);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(122, 20);
            this.chkCejas.TabIndex = 3;
            this.chkCejas.Text = "Cejas - RD$150";
            // 
            // chkDegradado
            // 
            this.chkDegradado.Location = new System.Drawing.Point(15, 125);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(157, 20);
            this.chkDegradado.TabIndex = 4;
            this.chkDegradado.Text = "Degradado - RD$450";
            // 
            // lblNivel
            // 
            this.lblNivel.Location = new System.Drawing.Point(15, 155);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(133, 16);
            this.lblNivel.TabIndex = 5;
            this.lblNivel.Text = "Nivel de Degradado:";
            // 
            // numNivel
            // 
            this.numNivel.Location = new System.Drawing.Point(160, 153);
            this.numNivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(120, 22);
            this.numNivel.TabIndex = 6;
            this.numNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCobrar.Location = new System.Drawing.Point(360, 100);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(180, 50);
            this.btnCobrar.TabIndex = 15;
            this.btnCobrar.Text = "GENERAR COBRO";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(360, 160);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.Size = new System.Drawing.Size(420, 280);
            this.txtRecibo.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(360, 445);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 23);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL: RD$ 0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 8;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(20, 470);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(130, 35);
            this.btnBackup.TabIndex = 12;
            this.btnBackup.Text = "Generar Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnVerRanking
            // 
            this.btnVerRanking.Location = new System.Drawing.Point(156, 470);
            this.btnVerRanking.Name = "btnVerRanking";
            this.btnVerRanking.Size = new System.Drawing.Size(130, 35);
            this.btnVerRanking.TabIndex = 11;
            this.btnVerRanking.Text = "Ver Ranking";
            this.btnVerRanking.Click += new System.EventHandler(this.btnVerRanking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(292, 470);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(130, 35);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(710, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 25);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(428, 470);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(130, 35);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(564, 470);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 35);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Reporte G.";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // clbProductos
            // 
            this.clbProductos.FormattingEnabled = true;
            this.clbProductos.Location = new System.Drawing.Point(20, 340);
            this.clbProductos.Name = "clbProductos";
            this.clbProductos.Size = new System.Drawing.Size(320, 89);
            this.clbProductos.TabIndex = 1;
            // 
            // lblProdInv
            // 
            this.lblProdInv.Location = new System.Drawing.Point(20, 320);
            this.lblProdInv.Name = "lblProdInv";
            this.lblProdInv.Size = new System.Drawing.Size(150, 16);
            this.lblProdInv.TabIndex = 0;
            this.lblProdInv.Text = "Productos Disponibles:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(816, 546);
            this.Controls.Add(this.lblProdInv);
            this.Controls.Add(this.clbProductos);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbBarberos);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVerRanking);
            this.Controls.Add(this.btnBackup);
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
            this.Text = "Peluquería El Cojo";
            this.grpServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}