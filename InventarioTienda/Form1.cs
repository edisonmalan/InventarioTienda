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
    public partial class Form1 : Form
    {
        Productos productos = new Productos();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                IngresoProducto  ingproducto = new IngresoProducto ();
                ingproducto.NombreProductoIn = txtNombreP.Text;
                ingproducto.CantidadIn = Convert.ToInt32(mtxtCantidad.Text);
                productos.AgregarProductos(ingproducto);
                MessageBox.Show("Datos almacenados correctamente!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dtgvIngreso.DataSource = productos.listProductos;
        }
        public bool Comprobar()
        {
            bool aux = false;
            if (mtxtCantidad.Text != "" && txtNombreP.Text != "" )
            {
                if (rtbnAbastos.Checked || rtbntBebidas.Checked || rtbnEmbutidos.Checked || rtbnFrutas.Checked || rtbnAseo.Checked || rtbnLacteos.Checked )
                {
                    if (chBodeguero.Checked || chDespachador.Checked)
                    {
                        aux = true;
                    }
                }
            }
            return aux;

        }
        public string Personal()
        {
            {
                string nomPersonal = "";
                if (rtbnAbastos.Checked)
                    nomPersonal = rtbnAbastos.Text;
                if (rtbntBebidas.Checked)
                    nomPersonal = rtbntBebidas.Text;
                if (rtbnEmbutidos.Checked)
                    nomPersonal = rtbnEmbutidos.Text;
                return nomPersonal ;
            }
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            try
            {

                if (Comprobar())
                {
                    string mensaje = " ";
                    frmProductoIngresado productoin = new frmProductoIngresado();
                    productoin.Show();
                    this.Hide();
                    if (chBodeguero.Checked)
                    {
                        productoin.lblPersonal.Text = chBodeguero.Text; 
                    }
                    else
                    {
                        productoin.lblPersonal.Text = chDespachador.Text; 
                    }
                    if (chBodeguero .Checked)
                    { 
                        mensaje = "Bodeguero";
                    }
                    else
                    {
                        mensaje = "Despachador";
                    }
                    productoin.lblSeccion.Text = mensaje;
                    /*productoin.Text = "Pedido de distribuidor " + Personal();*/
                }
                else
                {
                    MessageBox.Show("Ingrese toda la información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
