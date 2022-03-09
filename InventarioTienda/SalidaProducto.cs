using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTienda
{
    public class SalidaProducto
    {
        public string NombreProductoSA { set; get; }
        public int CantidaSA { set; get; }
        public SalidaProducto ()
        {

        }
        public SalidaProducto(string nombreProductoSA, int cantidaSA)
        {
            NombreProductoSA = nombreProductoSA;
            CantidaSA = cantidaSA;
        }
    }
}
