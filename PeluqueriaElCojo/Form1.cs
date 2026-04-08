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
        private List<Empleado> _barberos = new List<Empleado>();
        private List<Servicio> _serviciosFactura = new List<Servicio>();
        private Cliente _clienteSeleccionado = null;
        private Empleado _barberoSeleccionado = null;

        public Form1(bool esAdmin)
        {
            InitializeComponent();

            _barberos.Add(new Empleado("Juan Manuel", "Principal", 25000) { TotalVentas = 5800 });
            _barberos.Add(new Empleado("Roberto", "Junior", 18000) { TotalVentas = 3200 });

            ActualizarComboBarberos();
            cmbTipoCliente.DataSource = Enum.GetValues(typeof(TipoCliente));

            if (!esAdmin)
            {
                btnBackup.Enabled = false;
                btnVerRanking.Visible = false;
                lblStatus.Text = "Sesión: Barbero (Acceso Limitado)";
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                btnBackup.Enabled = true;
                btnVerRanking.Visible = true;
                lblStatus.Text = "Sesión: Administrador (Acceso Total)";
                lblStatus.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void ActualizarComboBarberos()
        {
            cmbBarberos.DataSource = null;
            cmbBarberos.DataSource = _barberos;
            cmbBarberos.DisplayMember = "Nombre";
        }

        private void cmbBarberos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBarberos.SelectedIndex >= 0)
            {
                _barberoSeleccionado = (Empleado)cmbBarberos.SelectedItem;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente(txtNombre.Text, txtTelefono.Text)
            {
                Tipo = (TipoCliente)cmbTipoCliente.SelectedItem
            };

            List<string> errores = Validador.Validar(nuevo);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Error de Validación");
                return;
            }

            _clientes.Add(nuevo);
            lstClientes.Items.Add(nuevo.Nombre);
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null || cmbBarberos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione cliente y barbero.");
                return;
            }

            _barberoSeleccionado = (Empleado)cmbBarberos.SelectedItem;
            _serviciosFactura.Clear();

            if (chkCorteNormal.Checked) _serviciosFactura.Add(new CorteNormal("Corte", 300, 30));
            if (chkDegradado.Checked) _serviciosFactura.Add(new Degradado("Degradado", 450, 45, (int)numNivel.Value));
            if (chkAfeitado.Checked) _serviciosFactura.Add(new Afeitado("Afeitado", 250, 25, chkToalla.Checked));
            if (chkCejas.Checked) _serviciosFactura.Add(new CorteCejas("Cejas", 150, 15));

            if (_serviciosFactura.Count == 0) return;

            decimal subtotal = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("      PELUQUERÍA EL COJO      ");
            sb.AppendLine("------------------------------");
            sb.AppendLine("Cliente: " + _clienteSeleccionado.Nombre);
            sb.AppendLine("Barbero: " + _barberoSeleccionado.Nombre);
            sb.AppendLine("Tipo: " + _clienteSeleccionado.Tipo.ToString());
            sb.AppendLine("------------------------------");

            foreach (Servicio s in _serviciosFactura)
            {
                subtotal += s.CalcularPrecio();
                sb.AppendLine(s.GenerarLineaRecibo());
            }

            decimal descuento = subtotal * _clienteSeleccionado.ObtenerDescuento();
            decimal montoNeto = subtotal - descuento;
            decimal itbis = montoNeto * 0.18m;
            decimal totalFinal = montoNeto + itbis;

            sb.AppendLine("------------------------------");
            sb.AppendLine(string.Format("Subtotal:   RD${0:N2}", subtotal));
            if (descuento > 0) sb.AppendLine(string.Format("Descuento: -RD${0:N2}", descuento));
            sb.AppendLine(string.Format("ITBIS 18%:  RD${0:N2}", itbis));
            sb.AppendLine("TOTAL:      RD$" + totalFinal.ToString("N2"));

            txtRecibo.Text = sb.ToString();
            lblTotal.Text = "TOTAL: RD$" + totalFinal.ToString("N2");

            _clienteSeleccionado.RegistrarVisita();
            _barberoSeleccionado.TotalVentas += totalFinal;
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            _barberos.Sort();
            MessageBox.Show(GeneradorReportes.ObtenerResumen<Empleado>(_barberos, "Ranking de Ventas"));
            ActualizarComboBarberos();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            GeneradorReportes.CrearBackup<Cliente>(_clientes, "Respaldo.txt");
            MessageBox.Show("Backup generado exitosamente.");
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteSeleccionado = _clientes[lstClientes.SelectedIndex];
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e) { }
    }
}