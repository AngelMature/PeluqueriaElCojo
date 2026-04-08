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
        private List<Servicio> _serviciosSeleccionados = new List<Servicio>();
        private List<Empleado> _barberos = new List<Empleado>();
        private Cliente _clienteActual = null;
        private bool _esAdmin;

        public Form1(bool esAdmin)
        {
            InitializeComponent();
            this._esAdmin = esAdmin;
            ValidarSesion();
            CargarDatos();
        }

        private void CargarDatos()
        {
            _barberos.Add(new Empleado("Juan Manuel", "Principal", 25000) { TotalVentas = 5800 });
            _barberos.Add(new Empleado("Roberto", "Junior", 18000) { TotalVentas = 3200 });
        }

        private void ValidarSesion()
        {
            if (!_esAdmin)
            {
                btnBackup.Enabled = false;
                btnVerRanking.Visible = false;
                lblStatus.Text = "Sesión: Barbero (Acceso Limitado)";
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                lblStatus.Text = "Sesión: Administrador (Acceso Total)";
                lblStatus.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNombre.Text, txtTelefono.Text);
            var errores = Validador.Validar(c);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Error");
                return;
            }

            _clientes.Add(c);
            lstClientes.Items.Add(c.Nombre);
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista derecha.");
                return;
            }

            _serviciosSeleccionados.Clear();

            if (chkCorteNormal.Checked) _serviciosSeleccionados.Add(new CorteNormal("Corte", 300, 30));
            if (chkDegradado.Checked) _serviciosSeleccionados.Add(new Degradado("Degradado", 450, 45, (int)numNivel.Value));
            if (chkAfeitado.Checked) _serviciosSeleccionados.Add(new Afeitado("Afeitado", 250, 25, chkToalla.Checked));
            if (chkCejas.Checked) _serviciosSeleccionados.Add(new CorteCejas("Cejas", 150, 15));

            if (_serviciosSeleccionados.Count == 0) return;

            _clienteActual.RegistrarVisita();
            decimal total = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("      PELUQUERÍA EL COJO      ");
            sb.AppendLine("------------------------------");
            sb.AppendLine("Cliente: " + _clienteActual.Nombre);
            sb.AppendLine("------------------------------");

            foreach (var s in _serviciosSeleccionados)
            {
                total += s.CalcularPrecio();
                sb.AppendLine(s.GenerarLineaRecibo());
            }

            decimal itbis = total * 0.18m;
            decimal final = total + itbis;

            sb.AppendLine("------------------------------");
            sb.AppendLine(string.Format("Subtotal:   RD${0:N2}", total));
            sb.AppendLine(string.Format("ITBIS (18%): RD${0:N2}", itbis));
            sb.AppendLine(string.Format("TOTAL:      RD${0:N2}", final));

            txtRecibo.Text = sb.ToString();
            lblTotal.Text = string.Format("TOTAL: RD${0:N2}", final);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            GeneradorReportes.CrearBackup<Cliente>(_clientes, "Respaldo.txt");
            MessageBox.Show("Respaldo guardado en Respaldo.txt");
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            _barberos.Sort();
            MessageBox.Show(GeneradorReportes.ObtenerResumen(_barberos, "Ventas Mensuales"));
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }

        private void numNivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkToalla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}