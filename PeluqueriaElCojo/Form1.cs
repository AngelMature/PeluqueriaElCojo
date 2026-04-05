using PeluqueriaElCojo.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Servicio> _servicios = new List<Servicio>();
        private Cliente _clienteActual = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            Cliente c = new Cliente(txtNombre.Text, txtTelefono.Text);
            _clientes.Add(c);
            lstClientes.Items.Add(c.Nombre); // Agregamos el nombre a la lista visual

            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteActual == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista.");
                return;
            }

            _servicios.Clear();

            // Corregido: Pasando los parámetros que piden los constructores de tus clases
            if (chkCorteNormal.Checked)
                _servicios.Add(new CorteNormal("Corte Normal", 300m, 30));

            if (chkDegradado.Checked)
                _servicios.Add(new Degradado("Degradado", 450m, 45, (int)numNivel.Value));

            if (chkAfeitado.Checked)
                _servicios.Add(new Afeitado("Afeitado", 250m, 25, chkToalla.Checked));

            if (chkCejas.Checked)
                _servicios.Add(new CorteCejas("Corte de Cejas", 150m, 15));

            if (_servicios.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un servicio.");
                return;
            }

            // Registrar la visita para el sistema de fidelidad (VIP/Regular)
            _clienteActual.RegistrarVisita();

            // Actualizar UI
            txtRecibo.Text = GenerarRecibo();
            lblTotal.Text = string.Format("TOTAL: RD${0:N2}", CalcularTotal());

            LimpiarChecks();
        }

        private decimal CalcularTotal()
        {
            decimal subtotal = 0;
            foreach (Servicio s in _servicios)
                subtotal += s.CalcularPrecio();

            decimal descuento = subtotal * _clienteActual.ObtenerDescuento();
            decimal baseConDescuento = subtotal - descuento;
            decimal itbis = baseConDescuento * 0.18m;

            return baseConDescuento + itbis;
        }

        private string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();
            decimal subtotal = 0;

            sb.AppendLine("╔═══════════════════════════════════════╗");
            sb.AppendLine("║          PELUQUERÍA EL COJO           ║");
            sb.AppendLine("║      Villa Mella, Santo Domingo       ║");
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine(string.Format("║ Cliente: {0,-28} ║", _clienteActual.Nombre));
            sb.AppendLine(string.Format("║ Tipo: {0,-31} ║", _clienteActual.Tipo));
            sb.AppendLine("╠═══════════════════════════════════════╣");

            foreach (Servicio s in _servicios)
            {
                sb.AppendLine(string.Format("║ {0,-37} ║", s.GenerarLineaRecibo()));
                subtotal += s.CalcularPrecio();
            }

            decimal porcDesc = _clienteActual.ObtenerDescuento();
            decimal montoDesc = subtotal * porcDesc;
            decimal neto = subtotal - montoDesc;
            decimal itbis = neto * 0.18m;
            decimal totalFinal = neto + itbis;

            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine(string.Format("║ Subtotal:            RD${0,12:N2} ║", subtotal));

            if (montoDesc > 0)
                sb.AppendLine(string.Format("║ Descuento ({0:P0}):   -RD${1,12:N2} ║", porcDesc, montoDesc));

            sb.AppendLine(string.Format("║ ITBIS (18%):         RD${0,12:N2} ║", itbis));
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine(string.Format("║ TOTAL A PAGAR:       RD${0,12:N2} ║", totalFinal));
            sb.AppendLine("╚═══════════════════════════════════════╝");
            sb.AppendLine("         ¡Gracias por preferirnos!       ");

            return sb.ToString();
        }

        private void LimpiarChecks()
        {
            chkCorteNormal.Checked = false;
            chkDegradado.Checked = false;
            chkAfeitado.Checked = false;
            chkToalla.Checked = false;
            chkCejas.Checked = false;
            numNivel.Value = 1;
        }
    }
}