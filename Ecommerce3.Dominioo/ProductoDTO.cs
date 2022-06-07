using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce3.Dominioo
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Nullable<short> Stock { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }


    }

    

   


}
