using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTienda
{
   public  class IngresoProducto
    {
        public string Nombre { set; get; }
        public int Cantidad { set; get; }
        public IngresoProducto ()
        {
        }

        public IngresoProducto(string nombreProductoIn, int cantidadIn)
        {
            Nombre = nombreProductoIn;
            Cantidad = cantidadIn;
        }
    }
}
