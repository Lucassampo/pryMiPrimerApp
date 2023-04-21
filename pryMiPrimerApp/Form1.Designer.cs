namespace pryMiPrimerApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSueldo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblAhorro = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblGastosExtras = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblmpuestos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 2;
            // 
            // mrcGastos
            // 
            this.mrcGastos.Controls.Add(this.textBox5);
            this.mrcGastos.Controls.Add(this.lblAhorro);
            this.mrcGastos.Controls.Add(this.textBox4);
            this.mrcGastos.Controls.Add(this.lblGastosExtras);
            this.mrcGastos.Controls.Add(this.textBox3);
            this.mrcGastos.Controls.Add(this.lblmpuestos);
            this.mrcGastos.Controls.Add(this.textBox2);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Location = new System.Drawing.Point(66, 48);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(191, 207);
            this.mrcGastos.TabIndex = 3;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "GASTOS";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 9;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 7;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 3;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(66, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(158, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mrcGastos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSueldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion de Gastos Mensuales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblGastosExtras;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblmpuestos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblAhorro;
    }
}

