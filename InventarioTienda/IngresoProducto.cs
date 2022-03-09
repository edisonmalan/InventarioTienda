using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTienda
{
   public  class IngresoProducto
    {
        public string NombreProductoIn { set; get; }
        public int CantidadIn { set; get; }
        public IngresoProducto ()
        {
        }

        public IngresoProducto(string nombreProductoIn, int cantidadIn)
        {
            NombreProductoIn = nombreProductoIn;
            CantidadIn = cantidadIn;
        }
    }
}
