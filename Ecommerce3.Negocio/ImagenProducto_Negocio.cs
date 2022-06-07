using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Datos;
using Ecommerce3.Dominioo;

namespace Ecommerce3.Negocio
{
    public class ImagenProducto_Negocio
    {
        private Producto objImagenProductoDTO = new Producto();

        public List<ImagenProductoDTO> Listar_Imagen()
        {
            return objImagenProductoDTO.Listar_Imagen();
        }
    }
}
