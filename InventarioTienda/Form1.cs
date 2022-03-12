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
                ingproducto.Nombre = txtNombreP.Text;
                ingproducto.Cantidad = Convert.ToInt32(mtxtCantidad.Text);
                productos.AgregarProductos(ingproducto);
                MessageBox.Show("Datos almacenados correctamente!!!");

            }
            catch (Exception ex)

            {
                MessageBox.Show("INGRESE TODOS LOS DATOS REQUERIDOS",ex.Message);
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
                if (rtbnPrincipal.Checked || rtbnSecundaria.Checked )
                {
                    if (chBodeguero.Checked || chDespachador.Checked)
                    {
                        aux = true;
                    }
                }
            }
            return aux;

        }
        private void btnPS_Click(object sender, EventArgs e)
       {
            try
            {


                if (Comprobar())
                {
                    frmProductoIngresado productoin = new frmProductoIngresado();
                    productoin.Show();
                    this.Hide();
                    if (rtbnPrincipal.Checked)
                    {
                        productoin.lblSecc.Text = rtbnPrincipal.Text;               
                    }
                    else
                    {
                            productoin.lblSecc.Text = rtbnSecundaria.Text;
                    }
                    if (chBodeguero.Checked)
                    {
                        productoin.lblPersonal.Text = chBodeguero.Text;
                       
                    }
                    else
                    {
                        productoin.lblPersonal.Text = chDespachador.Text;
                        
                    }
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
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
