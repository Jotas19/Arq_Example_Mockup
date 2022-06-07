using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce3.Dominioo
{
    public class FacturaDTO
    {

        public int IdFactura { get; set; }
        public int Numero { get; set; }
        public int IdCliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdFormaPago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal Neto { get; set; }
        public bool Estado { get; set; }
    }
}
