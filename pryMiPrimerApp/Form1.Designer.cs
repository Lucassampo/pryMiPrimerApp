namespace pryMiPrimerApp
{
    partial class frmGestionDeGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionDeGastos));
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.txtAhorros = new System.Windows.Forms.TextBox();
            this.lblAhorro = new System.Windows.Forms.Label();
            this.txtGastosExtras = new System.Windows.Forms.TextBox();
            this.lblGastosExtras = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblmpuestos = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtSueldoSobrante = new System.Windows.Forms.TextBox();
            this.lblSueldoSobrante = new System.Windows.Forms.Label();
            this.mrcGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSueldo.Location = new System.Drawing.Point(63, 25);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(51, 13);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "SUELDO";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(146, 25);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(74, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // mrcGastos
            // 
            this.mrcGastos.Controls.Add(this.lblSueldoSobrante);
            this.mrcGastos.Controls.Add(this.txtSueldoSobrante);
            this.mrcGastos.Controls.Add(this.txtAhorros);
            this.mrcGastos.Controls.Add(this.lblAhorro);
            this.mrcGastos.Controls.Add(this.txtGastosExtras);
            this.mrcGastos.Controls.Add(this.lblGastosExtras);
            this.mrcGastos.Controls.Add(this.txtImpuestos);
            this.mrcGastos.Controls.Add(this.lblmpuestos);
            this.mrcGastos.Controls.Add(this.txtAlquiler);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Location = new System.Drawing.Point(66, 48);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(191, 229);
            this.mrcGastos.TabIndex = 3;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "GASTOS";
            // 
            // txtAhorros
            // 
            this.txtAhorros.Location = new System.Drawing.Point(80, 170);
            this.txtAhorros.Name = "txtAhorros";
            this.txtAhorros.Size = new System.Drawing.Size(74, 20);
            this.txtAhorros.TabIndex = 9;
            // 
            // lblAhorro
            // 
            this.lblAhorro.AutoSize = true;
            this.lblAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorro.Location = new System.Drawing.Point(6, 170);
            this.lblAhorro.Name = "lblAhorro";
            this.lblAhorro.Size = new System.Drawing.Size(58, 17);
            this.lblAhorro.TabIndex = 8;
            this.lblAhorro.Text = "Ahorros";
            // 
            // txtGastosExtras
            // 
            this.txtGastosExtras.Location = new System.Drawing.Point(80, 133);
            this.txtGastosExtras.Name = "txtGastosExtras";
            this.txtGastosExtras.Size = new System.Drawing.Size(74, 20);
            this.txtGastosExtras.TabIndex = 7;
            // 
            // lblGastosExtras
            // 
            this.lblGastosExtras.AutoSize = true;
            this.lblGastosExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosExtras.Location = new System.Drawing.Point(6, 133);
            this.lblGastosExtras.Name = "lblGastosExtras";
            this.lblGastosExtras.Size = new System.Drawing.Size(72, 13);
            this.lblGastosExtras.TabIndex = 6;
            this.lblGastosExtras.Text = "Gastos Extras";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(80, 91);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(74, 20);
            this.txtImpuestos.TabIndex = 5;
            // 
            // lblmpuestos
            // 
            this.lblmpuestos.AutoSize = true;
            this.lblmpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmpuestos.Location = new System.Drawing.Point(6, 92);
            this.lblmpuestos.Name = "lblmpuestos";
            this.lblmpuestos.Size = new System.Drawing.Size(72, 17);
            this.lblmpuestos.TabIndex = 4;
            this.lblmpuestos.Text = "Impuestos";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(80, 45);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(74, 20);
            this.txtAlquiler.TabIndex = 3;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(6, 48);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(55, 17);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 283);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(78, 37);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Silver;
            this.cmdCancelar.Location = new System.Drawing.Point(233, 283);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 37);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSueldoSobrante
            // 
            this.txtSueldoSobrante.Location = new System.Drawing.Point(101, 199);
            this.txtSueldoSobrante.Name = "txtSueldoSobrante";
            this.txtSueldoSobrante.Size = new System.Drawing.Size(74, 20);
            this.txtSueldoSobrante.TabIndex = 10;
            // 
            // lblSueldoSobrante
            // 
            this.lblSueldoSobrante.AutoSize = true;
            this.lblSueldoSobrante.Location = new System.Drawing.Point(9, 202);
            this.lblSueldoSobrante.Name = "lblSueldoSobrante";
            this.lblSueldoSobrante.Size = new System.Drawing.Size(86, 13);
            this.lblSueldoSobrante.TabIndex = 11;
            this.lblSueldoSobrante.Text = "Sueldo Sobrante";
            // 
            // frmGestionDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 332);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcGastos);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionDeGastos";
            this.Text = "Gestion de Gastos Mensuales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.TextBox txtGastosExtras;
        private System.Windows.Forms.Label lblGastosExtras;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblmpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtAhorros;
        private System.Windows.Forms.Label lblAhorro;
        private System.Windows.Forms.Label lblSueldoSobrante;
        private System.Windows.Forms.TextBox txtSueldoSobrante;
    }
}

