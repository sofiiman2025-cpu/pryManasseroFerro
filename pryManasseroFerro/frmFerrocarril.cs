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
            // Validaciones de entrada
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese a donde desea ir", "Gestión de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Ingrese la distancia a recorrer", "Gestión de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

            if (!double.TryParse(txtDistancia.Text, out double distancia))
            {
                MessageBox.Show("La distancia debe ser un número válido", "Gestión de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

            int dias = (int)numDias.Value;
            double precioKm = 5;

            // Calcular ida y vuelta
            double totalDistancia = distancia * 2;

            // Calcular precio sin descuento
            double total = totalDistancia * precioKm;

            // Aplicar descuento si corresponde (50% cuando distancia >= 100 y estadía >= 7 días)
            if (distancia >= 100 && dias >= 7)
            {
                total *= 0.5; // Descuento del 50%
            }

            // Mostrar resultado
            MessageBox.Show($"El precio total del boleto es: ${total:F2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pMostrar.Visible = true;

            // Agregar a la datagridview
            dgvDatos.Rows.Add(distancia, dias, total);
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
