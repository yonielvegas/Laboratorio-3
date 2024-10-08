namespace Laboratorio_3
{
    partial class FrmProblema2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCoincidencia = new System.Windows.Forms.TextBox();
            this.dgvNumero = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(364, 247);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 39);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNumero);
            this.panel1.Controls.Add(this.txtCoincidencia);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Location = new System.Drawing.Point(30, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 370);
            this.panel1.TabIndex = 1;
            // 
            // txtCoincidencia
            // 
            this.txtCoincidencia.Location = new System.Drawing.Point(96, 255);
            this.txtCoincidencia.Name = "txtCoincidencia";
            this.txtCoincidencia.Size = new System.Drawing.Size(202, 22);
            this.txtCoincidencia.TabIndex = 1;
            // 
            // dgvNumero
            // 
            this.dgvNumero.AllowUserToAddRows = false;
            this.dgvNumero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvNumero.Location = new System.Drawing.Point(60, 73);
            this.dgvNumero.Name = "dgvNumero";
            this.dgvNumero.RowHeadersWidth = 51;
            this.dgvNumero.RowTemplate.Height = 24;
            this.dgvNumero.Size = new System.Drawing.Size(623, 131);
            this.dgvNumero.TabIndex = 2;
            this.dgvNumero.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvNumero_EditingControlShowing);
            this.dgvNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvNumero_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProblema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProblema2";
            this.Text = "FrmProblema2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProblema2_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCoincidencia;
        private System.Windows.Forms.DataGridView dgvNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}