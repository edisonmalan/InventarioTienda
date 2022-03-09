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
    }
}
