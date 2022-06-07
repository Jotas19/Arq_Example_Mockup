using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce3.Dominioo
{
    public class ImagenProductoDTO
    {

        public int IdImagenProducto { get; set; }
        public int IdProducto { get; set; }
        public string Url { get; set; }
        public bool EsPortada { get; set; }
    }
}
