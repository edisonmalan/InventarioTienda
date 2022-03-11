using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTienda
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Form1 ingresoform1 = new Form1();
            ingresoform1.Show();
            ingresoform1.lblUsuario.Text = txtUsuario.Text;
            ingresoform1.lblCedula.Text = txtCedula.Text;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
