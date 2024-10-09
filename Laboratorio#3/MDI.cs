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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaBank frm = new CuentaBank();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProblema2 obj2 = new FrmProblema2();
            obj2.MdiParent = this;
            obj2.WindowState = FormWindowState.Maximized;
            obj2.Show();
        }

        private void problema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas obj2 = new FrmVentas();
            obj2.MdiParent = this;
            obj2.WindowState = FormWindowState.Maximized;
            obj2.Show();
        }
    }
}
