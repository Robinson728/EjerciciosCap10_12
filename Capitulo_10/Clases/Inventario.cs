using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCap10_12.Capitulo_10.Clases
{
    public class Inventario
    {
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public string Categoria { get; set; }

        public Inventario()
        {
            CodigoProducto = 0;
            Descripcion = string.Empty;
            Stock = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Categoria = string.Empty;
        }
    }
}
