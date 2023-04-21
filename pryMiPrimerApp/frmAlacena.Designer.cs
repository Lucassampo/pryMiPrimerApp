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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Shampoo");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Aconcdicionador");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Jabon liquido");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Jabon cuerpo");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("HIGIENE", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Fideos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Arroz");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Yerba");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Azucar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ALIMENTOS", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mrcProductos = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.mrcProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcProductos
            // 
            this.mrcProductos.Controls.Add(this.treeView3);
            this.mrcProductos.Controls.Add(this.treeView2);
            this.mrcProductos.Controls.Add(this.treeView1);
            this.mrcProductos.Location = new System.Drawing.Point(12, 12);
            this.mrcProductos.Name = "mrcProductos";
            this.mrcProductos.Size = new System.Drawing.Size(532, 426);
            this.mrcProductos.TabIndex = 0;
            this.mrcProductos.TabStop = false;
            this.mrcProductos.Text = "Productos";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Location = new System.Drawing.Point(0, 32);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Nodo1";
            treeNode7.Text = "Shampoo";
            treeNode8.Name = "Nodo2";
            treeNode8.Text = "Aconcdicionador";
            treeNode9.Name = "Nodo3";
            treeNode9.Text = "Jabon liquido";
            treeNode10.Name = "Nodo4";
            treeNode10.Text = "Jabon cuerpo";
            treeNode11.BackColor = System.Drawing.Color.Lavender;
            treeNode11.Name = "Higiene";
            treeNode11.Text = "HIGIENE";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(158, 97);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(0, 151);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Fideos";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Arroz";
            treeNode3.Name = "Nodo3";
            treeNode3.Text = "Yerba";
            treeNode4.Name = "Nodo4";
            treeNode4.Text = "Azucar";
            treeNode5.Name = "Nodo5";
            treeNode5.Text = "Nodo5";
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "ALIMENTOS";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView2.Size = new System.Drawing.Size(158, 103);
            this.treeView2.TabIndex = 1;
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(219, 32);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(156, 97);
            this.treeView3.TabIndex = 2;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.mrcProductos);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.mrcProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox mrcProductos;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TreeView treeView2;
    }
}