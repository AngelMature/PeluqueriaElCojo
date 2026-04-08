using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Servicio> _serviciosFactura = new List<Servicio>();
        private List<Empleado> _barberos = new List<Empleado>();
        private Cliente _clienteActual = null;
        private bool _esAdmin;

        public Form1(bool esAdmin)
        {
            InitializeComponent();
            this._esAdmin = esAdmin;

            AplicarPermisos(); // aquí aplicamos control de roles

            _barberos.Add(new Empleado("Juan Manuel", "Principal", 25000) { TotalVentas = 5800 });
            _barberos.Add(new Empleado("Roberto", "Junior", 18000) { TotalVentas = 3200 });
        }

        //  MÉTODO NUEVO PARA CONTROL DE PRIVILEGIOS
        private void AplicarPermisos()
        {
            if (!_esAdmin)
            {
                btnBackup.Visible = false;
                btnVerRanking.Visible = false;
                lblStatus.Text = "Sesión: Barbero";
            }
            else
            {
                btnBackup.Visible = true;
                btnVerRanking.Visible = true;
                lblStatus.Text = "Sesión: Administrador";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNombre.Text, txtTelefono.Text);

            var errores = Validador.Validar(c);
            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Validación");
                return;
            }

            _clientes.Add(c);
            lstClientes.Items.Add(c.Nombre);
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteActual == null) return;
            _serviciosFactura.Clear();

            if (chkCorteNormal.Checked) _serviciosFactura.Add(new CorteNormal("Corte", 300, 30));
            if (chkDegradado.Checked) _serviciosFactura.Add(new Degradado("Degradado", 450, 45, (int)numNivel.Value));
            if (chkAfeitado.Checked) _serviciosFactura.Add(new Afeitado("Afeitado", 250, 25, chkToalla.Checked));
            if (chkCejas.Checked) _serviciosFactura.Add(new CorteCejas("Cejas", 150, 15));

            _clienteActual.RegistrarVisita();
            txtRecibo.Text = GenerarRecibo();
            lblTotal.Text = "TOTAL: RD$" + CalcularMontoFinal().ToString("N2");
        }

        private decimal CalcularMontoFinal()
        {
            decimal total = 0;
            foreach (var s in _serviciosFactura)
            {
                total += s.CalcularPrecio();
            }
            return total + (total * 0.18m);
        }

        private string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();
            decimal subtotal = 0;
            sb.AppendLine("      PELUQUERÍA EL COJO      ");
            sb.AppendLine("------------------------------");
            foreach (var s in _serviciosFactura)
            {
                subtotal += s.CalcularPrecio();
                sb.AppendLine(s.GenerarLineaRecibo());
            }
            decimal itbis = subtotal * 0.18m;
            sb.AppendLine("------------------------------");
            sb.AppendLine("ITBIS (18%): RD$" + itbis.ToString("N2"));
            sb.AppendLine("TOTAL: RD$" + (subtotal + itbis).ToString("N2"));
            return sb.ToString();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            GeneradorReportes.CrearBackup<Cliente>(_clientes, "Backup_Sistema.txt");
            MessageBox.Show("Archivo de respaldo creado exitosamente.");
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            _barberos.Sort();
            string resumen = GeneradorReportes.ObtenerResumen(_barberos, "Ranking Barberos");
            MessageBox.Show(resumen);
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }
    }
}