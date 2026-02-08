namespace PeluqueriaElCojo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
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
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(444, 54);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(424, 142);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(424, 182);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(325, 84);
            this.lstClientes.TabIndex = 3;
            this.lstClientes.Click += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged_1);
            // 
            // chkCorteNormal
            // 
            this.chkCorteNormal.AutoSize = true;
            this.chkCorteNormal.Location = new System.Drawing.Point(173, 101);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(167, 20);
            this.chkCorteNormal.TabIndex = 4;
            this.chkCorteNormal.Text = "Corte Normal (RD$200)";
            this.chkCorteNormal.UseVisualStyleBackColor = true;
            this.chkCorteNormal.CheckedChanged += new System.EventHandler(this.chkCorteNormal_CheckedChanged);
            this.chkCorteNormal.Click += new System.EventHandler(this.chkCorteNormal_CheckedChanged);
            // 
            // chkDegradado
            // 
            this.chkDegradado.AutoSize = true;
            this.chkDegradado.Location = new System.Drawing.Point(173, 264);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(99, 20);
            this.chkDegradado.TabIndex = 5;
            this.chkDegradado.Text = "Degradado";
            this.chkDegradado.UseVisualStyleBackColor = true;
            this.chkDegradado.CheckedChanged += new System.EventHandler(this.chkDegradado_CheckedChanged);
            this.chkDegradado.Click += new System.EventHandler(this.chkDegradado_CheckedChanged);
            // 
            // numNivel
            // 
            this.numNivel.Location = new System.Drawing.Point(424, 99);
            this.numNivel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(120, 22);
            this.numNivel.TabIndex = 6;
            this.numNivel.ValueChanged += new System.EventHandler(this.numNivel_ValueChanged);
            this.numNivel.Click += new System.EventHandler(this.numNivel_ValueChanged);
            // 
            // chkAfeitado
            // 
            this.chkAfeitado.AutoSize = true;
            this.chkAfeitado.Location = new System.Drawing.Point(173, 145);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(138, 20);
            this.chkAfeitado.TabIndex = 7;
            this.chkAfeitado.Text = "Afeitado (RD$150)";
            this.chkAfeitado.UseVisualStyleBackColor = true;
            this.chkAfeitado.CheckedChanged += new System.EventHandler(this.chkAfeitado_CheckedChanged);
            this.chkAfeitado.Click += new System.EventHandler(this.chkAfeitado_CheckedChanged);
            // 
            // chkToalla
            // 
            this.chkToalla.AutoSize = true;
            this.chkToalla.Location = new System.Drawing.Point(173, 182);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(137, 20);
            this.chkToalla.TabIndex = 8;
            this.chkToalla.Text = "+ Toalla (+RD$50)";
            this.chkToalla.UseVisualStyleBackColor = true;
            this.chkToalla.CheckedChanged += new System.EventHandler(this.chkToalla_CheckedChanged);
            this.chkToalla.Click += new System.EventHandler(this.chkToalla_CheckedChanged);
            // 
            // chkCejas
            // 
            this.chkCejas.AutoSize = true;
            this.chkCejas.Location = new System.Drawing.Point(173, 223);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(116, 20);
            this.chkCejas.TabIndex = 9;
            this.chkCejas.Text = "Cejas (RD$75)";
            this.chkCejas.UseVisualStyleBackColor = true;
            this.chkCejas.CheckedChanged += new System.EventHandler(this.chkCejas_CheckedChanged);
            this.chkCejas.Click += new System.EventHandler(this.chkCejas_CheckedChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(424, 292);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 10;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.TextChanged += new System.EventHandler(this.btnCobrar_Click_1);
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(12, 416);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(776, 22);
            this.txtRecibo.TabIndex = 11;
            this.txtRecibo.Text = "Multiline, Consolas";
            this.txtRecibo.Click += new System.EventHandler(this.txtRecibo_TextChanged);
            this.txtRecibo.TextChanged += new System.EventHandler(this.txtRecibo_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(316, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "TOTAL: RD$0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

