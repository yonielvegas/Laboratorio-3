using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class MetodoGenerales
{
    public static void numeroDecimal(KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
        {
            return;
        }
        e.Handled = true;
    }

    public static void editarDataGridView(object sender, DataGridViewEditingControlShowingEventArgs e, KeyPressEventHandler keyPressHandler)
    {
        TextBox txt = e.Control as TextBox;
        if (txt != null)
        {
            //evitar la ejecución múltiple del mismo evento
            txt.KeyPress -= keyPressHandler;
            txt.KeyPress += keyPressHandler;
        }
    }


    public static void agregarNumero(DataGridView dgvNumero, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1)
        {
            dgvNumero.ColumnCount++;
        }
    }

    public static void eliminarCelda(DataGridView dgvNumero, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F2 && dgvNumero.ColumnCount > 1)
        {
            dgvNumero.ColumnCount--;
        }
    }

    public static void eliminarCoincidencia(int numberToRemove, List<int> numeros, DataGridView dgvNumero)
    {
        // Eliminar todas las coincidencias en la lista
        numeros.RemoveAll(num => num == numberToRemove);

        // Ajustar el número de columnas según el tamaño de la nueva lista
        dgvNumero.ColumnCount = numeros.Count;

        // Actualizar las celdas con los valores no coincidentes
        for (int i = 0; i < numeros.Count; i++)
        {
            dgvNumero.Rows[0].Cells[i].Value = numeros[i];
        }

        if (dgvNumero.Rows.Count > 0)
        {
            // Limpiar las celdas restantes que no se llenen
            for (int i = numeros.Count; i < dgvNumero.Rows[0].Cells.Count; i++)
            {
                dgvNumero.Rows[0].Cells[i].Value = null;
            }
        }
        else
        {
            dgvNumero.RowCount = 1;

        }
    }
}