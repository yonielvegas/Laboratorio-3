using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class MetodoGenerales
{
    public static void numeroDecimal(KeyPressEventArgs e, Object sender)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
        {
            return;
        }
        //TextBox txt = sender as TextBox;
        e.Handled = true;
    }

    public static void editarDataGridView(object sender, DataGridViewEditingControlShowingEventArgs e, KeyPressEventHandler keyPressHandler)
    {
        TextBox txt = e.Control as TextBox;
        if (txt != null)
        {
            txt.KeyPress -= keyPressHandler;
            txt.KeyPress += keyPressHandler;
        }
    }

    public static void numeroDecimal(TextBox cajaDeTexto, KeyPressEventArgs e)
    {
        //Se admite la pulsacion (escribir uno por uno) y que sea un digito numerico
        if (char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
        {
            return;
        }

        //se admite un . y que sea solo uno
        if (e.KeyChar == '.' && !cajaDeTexto.Text.Contains('.'))
        {
            return;
        }
        e.Handled = true;
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

    public static void RemoveNumber(int numberToRemove, List<int> numeros, DataGridView dgvNumero)
    {
        // Eliminar todas las coincidencias en la lista
        numeros.RemoveAll(num => num == numberToRemove);

        // Ajustar el número de columnas según el tamaño de la lista
        dgvNumero.ColumnCount = numeros.Count;

        // Actualizar las celdas de la fila con los valores restantes
        for (int i = 0; i < numeros.Count; i++)
        {
            dgvNumero.Rows[0].Cells[i].Value = numeros[i];
        }

        // Limpiar las celdas restantes que no se llenen
        for (int i = numeros.Count; i < dgvNumero.Rows[0].Cells.Count; i++)
        {
            dgvNumero.Rows[0].Cells[i].Value = null; // Asegúrate de que las celdas restantes estén vacías
        }
    }
}