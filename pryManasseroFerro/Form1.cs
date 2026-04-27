using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroFerro
{
    public partial class frmOrganizacionferro : Form
    {
        public frmOrganizacionferro()
        {
            InitializeComponent();
        }

        private void frmOrganizacionferro_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            frmCarga VentanaProducto = new frmCarga();
            this.Hide();
            VentanaProducto.ShowDialog();
            this.Show();

            // Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Debe ingresar la distancia");
                return;
            }

            double distancia;
            int dias = (int)numDias.Value;
            double precioKm = 5;
            double total;
            double totalDistancia;

            // Validar que sea número
            if (!double.TryParse(txtDistancia.Text, out distancia))
            {
                MessageBox.Show("Ingrese una distancia válida");
                return;
            }

            // Calcular ida y vuelta
            totalDistancia = distancia * 2;

            // Precio base
            total = totalDistancia * precioKm;

            // Descuento
            if (distancia >= 100 && dias >= 7)
            {
                total = total * 0.5;
            }

            // Mostrar resultado
            MessageBox.Show("El precio del boleto es: $" + total);

        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Debe ingresar la distancia", "Boletería", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
