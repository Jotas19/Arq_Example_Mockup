using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Datos;
using Ecommerce3.Dominioo;

namespace Ecommerce3.Negocio
{
    public class Producto_Negocio
    {
        private Producto objProductoDTO = new Producto();

        public List<ProductoDTO> Listar()
        {
            return objProductoDTO.Listar();
        }
    }
}
