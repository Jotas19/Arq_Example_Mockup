using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce3.Dominioo
{
    public class CalificacionDTO
    {

        public int IdCalificacion { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public decimal Valoracion { get; set; }
    }
}
