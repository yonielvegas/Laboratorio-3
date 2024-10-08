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
    public partial class CuentaBank : Form
    {
        private double saldo = 0;
        public CuentaBank()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombreCliente.Text;
            try
            {
                saldo = Convert.ToDouble(txtMontoInicial.Text);
            }catch (Exception ex)
            {
                MessageBox.Show("Saldo Incorrecto");
            }
            txtSalarioFinal.Text = saldo.ToString();
            MessageBox.Show("Cuenta Creada Con Exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool detonar;
            Double monto = 0;
            detonar = rbDeposito.Checked;
            try
            {
                monto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese el Monto", "Monto a Cargar"));
            }catch(Exception ex)
            {
                MessageBox.Show("Monto Incorrecto");
                return;
            }
            


            ProcesosBancarios obj = new ProcesosBancarios();
            if (monto > 0)
              {
                 obj.setDinero(saldo, monto);
                 obj.CalcularDetonar(detonar,ref lstDeposito,ref lstRetiro);
                 saldo = obj.getSaldo();
                txtSalarioFinal.Text = saldo.ToString("F2");
              }
            else
            {
                MessageBox.Show("El Monto debe ser mayor a 0");
            }
        }

        private void rbDeposito_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
