using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Datos;
using Ecommerce3.Dominioo;

namespace Ecommerce3.Negocio
{
    public class Categoria_Negocio
    {

        private Categoria objCategoriaDTO = new Categoria();

        public List<CategoriaDTO> Listar_Categoria()
        {
            return objCategoriaDTO.Listar_Categoria();
        }
    }
}
