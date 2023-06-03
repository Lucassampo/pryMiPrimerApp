namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtNombreDelProduto = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.GroupBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.Productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreDelProduto
            // 
            this.txtNombreDelProduto.Location = new System.Drawing.Point(140, 46);
            this.txtNombreDelProduto.Name = "txtNombreDelProduto";
            this.txtNombreDelProduto.Size = new System.Drawing.Size(121, 22);
            this.txtNombreDelProduto.TabIndex = 0;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCantidad.Location = new System.Drawing.Point(140, 120);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 24);
            this.cmbCantidad.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Hiegene",
            "Enlatados"});
            this.cmbCategoria.Location = new System.Drawing.Point(140, 80);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Location = new System.Drawing.Point(-3, 46);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(137, 16);
            this.lblNombreDelProducto.TabIndex = 3;
            this.lblNombreDelProducto.Text = "Nombre Del Producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(0, 83);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(0, 124);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.cmdCancelar);
            this.Productos.Controls.Add(this.cmdAceptar);
            this.Productos.Controls.Add(this.txtNombreDelProduto);
            this.Productos.Controls.Add(this.lblCategoria);
            this.Productos.Controls.Add(this.cmbCategoria);
            this.Productos.Controls.Add(this.cmbCantidad);
            this.Productos.Controls.Add(this.lblCantidad);
            this.Productos.Controls.Add(this.lblNombreDelProducto);
            this.Productos.Location = new System.Drawing.Point(12, 12);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(319, 265);
            this.Productos.TabIndex = 7;
            this.Productos.TabStop = false;
            this.Productos.Text = "Productos";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(178, 191);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(107, 43);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(28, 191);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(106, 43);
            this.cmdAceptar.TabIndex = 6;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.ItemHeight = 16;
            this.lstAlacena.Location = new System.Drawing.Point(12, 283);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(315, 132);
            this.lstAlacena.TabIndex = 8;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 554);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.Productos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNombreDelProduto;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox Productos;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ListBox lstAlacena;
    }
}