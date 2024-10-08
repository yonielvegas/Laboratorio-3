using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_3
{
    public partial class FrmProblema2 : Form
    {
        public FrmProblema2()
        {
            InitializeComponent();
            dgvNumero.RowCount = 1;
            this.KeyPreview = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crear y llenar la lista a partir de la primera fila del DataGridView
            List<int> numeros = dgvNumero.Rows[0].Cells
                .Cast<DataGridViewCell>()
                .Where(cell => cell.Value != null && int.TryParse(cell.Value.ToString(), out _))
                .Select(cell => Convert.ToInt32(cell.Value))
                .ToList();

            // Intentar obtener el número a eliminar del TextBox
            if (int.TryParse(txtCoincidencia.Text, out int numberToRemove))
            {
                MetodoGenerales.RemoveNumber(numberToRemove, numeros, dgvNumero); // Eliminar el número y actualizar el DataGridView
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }

        }

        private void dgvNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoGenerales.numeroDecimal(e, sender);

        }
        private void dgvNumero_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            MetodoGenerales.editarDataGridView(sender, e, new KeyPressEventHandler(dgvNumero_KeyPress));

        }
        private void FrmProblema2_KeyDown(object sender, KeyEventArgs e)
        {
            MetodoGenerales.agregarNumero(dgvNumero, e);
            MetodoGenerales.eliminarCelda(dgvNumero, e);
        }
    }
}
