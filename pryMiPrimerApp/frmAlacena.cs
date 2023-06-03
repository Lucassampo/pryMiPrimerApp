using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmAlacena : Form
    {
        private string varNombreDelProducto;
        private int varCantidad;
        private object varCategoria;
        private object lstCantidad;
        private object lstCatProductos;

        public frmAlacena()
        {
            InitializeComponent();

      }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            varNombreDelProducto = txtNombreDelProduto.Text;
            varCantidad = Convert.ToInt32(cmbCantidad.Text);
            varCategoria = lblCantidad.Text;
            lstAlacena.Items.Add(varNombreDelProducto + " " +  varCategoria +" " + varCantidad );

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
