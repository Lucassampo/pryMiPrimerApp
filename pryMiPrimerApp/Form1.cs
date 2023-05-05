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
    public partial class frmGestionDeGastos : Form
    {
        decimal varSueldo;
        decimal varAlquieler;
        decimal varImpuestos;
        decimal varGastosExtras;
        decimal varAhorros;
        decimal varSueldoSobrante;

        public frmGestionDeGastos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            varSueldo = 0;
            varAlquieler = 0;
            varImpuestos = 0;
            varGastosExtras = 0;
            varAhorros = 0;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            varSueldo=Convert.ToDecimal(txtSueldo.Text);
            varAlquieler=Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos=Convert.ToDecimal(txtImpuestos.Text);
            varGastosExtras=Convert.ToDecimal(txtGastosExtras.Text);
            varAhorros = Convert.ToDecimal(txtAhorros.Text);
        
        varSueldoSobrante = varSueldo - (varAlquieler + varImpuestos + varGastosExtras + varAhorros );
        
            txtSueldoSobrante.Text = varSueldoSobrante.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
