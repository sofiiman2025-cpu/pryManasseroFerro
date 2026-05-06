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
            //Declaración de variables
            double distancia= Convert.ToDouble(txtDistancia.Text) ;
            int dias= (int)numDias.Value;
            double precioKm = 5;
            double total;
            double totalDistancia;

            if (txtDistancia.Text == "")
                
            {
                MessageBox.Show("Ingrese la distancia a recorrer", "Gestión de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }



        //calcular ida y vuelta 
        totalDistancia = distancia * 2;

            //Calcular precio sin descuento
            total = totalDistancia * precioKm;

            //Aplicar descuento si corresponde 
            if (distancia >= 100 && distancia >= 7)

            {
                total = total * 0.5; // Descuento del 5%
            }
            //Mostrar resultado
            MessageBox.Show("El precio total del boleto es: $" + total);
            pMostrar.Visible = true;
            //Agregar a la datagridview
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
