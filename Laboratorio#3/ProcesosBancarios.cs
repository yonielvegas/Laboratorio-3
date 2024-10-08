using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    internal class ProcesosBancarios
    {
        private double saldo;
        private double monto;

        public void setDinero(double saldo, double monto)
        {
            this.saldo = saldo;
            this.monto = monto;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void CalcularDetonar(bool detonar, ref ListBox deposito, ref ListBox retiro)
        {
            if (detonar)
            {
                saldo += monto;
                deposito.Items.Add("+" + monto);
            }
            else
            {
                if(monto <= saldo)
                {
                    saldo -= monto;
                    retiro.Items.Add("-" + monto);
                }
                else
                {
                    MessageBox.Show("Monto Mayor a saldo, imposible retirar!");
                }
            }
        }
    }
}
