using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTienda
{
   public  class Productos
    {
        public List<IngresoProducto> listProductos { set; get; }
        public Productos()
        {
            listProductos = new List<IngresoProducto>();
        }
        public void AgregarProductos(IngresoProducto ingresoProducto )
        {
            listProductos.Add(ingresoProducto); 
        }
     
    }
}
