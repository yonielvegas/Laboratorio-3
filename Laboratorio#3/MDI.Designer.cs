namespace Laboratorio_3
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaBancariaToolStripMenuItem,
            this.problema2ToolStripMenuItem,
            this.problema3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaBancariaToolStripMenuItem
            // 
            this.cuentaBancariaToolStripMenuItem.Name = "cuentaBancariaToolStripMenuItem";
            this.cuentaBancariaToolStripMenuItem.Size = new System.Drawing.Size(238, 41);
            this.cuentaBancariaToolStripMenuItem.Text = "Cuenta Bancaria";
            this.cuentaBancariaToolStripMenuItem.Click += new System.EventHandler(this.cuentaBancariaToolStripMenuItem_Click);
            // 
            // problema2ToolStripMenuItem
            // 
            this.problema2ToolStripMenuItem.Name = "problema2ToolStripMenuItem";
            this.problema2ToolStripMenuItem.Size = new System.Drawing.Size(195, 41);
            this.problema2ToolStripMenuItem.Text = "Problema #2";
            this.problema2ToolStripMenuItem.Click += new System.EventHandler(this.problema2ToolStripMenuItem_Click);
            // 
            // problema3ToolStripMenuItem
            // 
            this.problema3ToolStripMenuItem.Name = "problema3ToolStripMenuItem";
            this.problema3ToolStripMenuItem.Size = new System.Drawing.Size(188, 41);
            this.problema3ToolStripMenuItem.Text = "Problema#3";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 800);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema3ToolStripMenuItem;
    }
}

