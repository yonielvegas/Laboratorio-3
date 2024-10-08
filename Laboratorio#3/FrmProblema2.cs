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
            // intercepta y maneja las pulsaciones de teclas antes que cualquier control hijo
            this.KeyPreview = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crear y llenar la lista 
            List<int> numeros = dgvNumero.Rows[0].Cells
                //Lo convierte en una coleccion fuertemente tipada para trabajr con Linq
                .Cast<DataGridViewCell>()
                //trabaja con las celdas que tienen un valor entero
                .Where(cell => cell.Value != null && int.TryParse(cell.Value.ToString(), out _))
                //convierte el valor de cada celda
                .Select(cell => Convert.ToInt32(cell.Value))
                //convierte el resultado en una lista de enteros
                .ToList();

            //Eliminar coincidencias
            if (int.TryParse(txtCoincidencia.Text, out int numeroCoincidencia))
            {
                if (numeros.Contains(numeroCoincidencia)) 
                {
                    MetodoGenerales.eliminarCoincidencia(numeroCoincidencia, numeros, dgvNumero); 
                }
                else
                {
                    MessageBox.Show("El número no se encuentra en la lista."); 
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido."); 
            }


        }

        private void dgvNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoGenerales.numeroDecimal(e);

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

        private void txtCoincidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoGenerales.numeroDecimal(e);

        }
    }
}
