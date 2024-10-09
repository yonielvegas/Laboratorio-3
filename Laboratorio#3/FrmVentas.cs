using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class FrmVentas : Form
    {
        private Ventas ventas;
        private int numVentas;
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener el número de ventas
            if (int.TryParse(txtNumventas.Text, out numVentas))
            {
                ventas = new Ventas(numVentas);
                for (int i = 0; i < numVentas; i++)
                {
                    // Suponiendo que se utiliza un InputBox para obtener los importes
                    decimal importe = decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el importe de la venta " + (i + 1)));
                    ventas.AgregarVenta(i, importe);
                }
                MessageBox.Show("Ventas agregadas.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ventas.OrdenarImportes();
            var importesFiltrados = ventas.ObtenerImportesEntre(50, 287);
            dgvVentas.DataSource = null;
            dgvVentas.Rows.Clear();

            foreach (var importe in importesFiltrados)
            {
                dgvVentas.Rows.Add(importe);
            }
        }
    }
}
