using Ecommerce.Datos.Extensiones;
using Ecommerce.Datos.Repositorios;
using Ecommerce3.Dominioo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Ecommmerce3.servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private ProductoRepositorio repositorio;
        public ProductoController()
        {
            repositorio = new ProductoRepositorio();
        }
        [HttpGet]
        public IEnumerable<ProductoDTO> ObtenerProductos()
        {

            var listado = repositorio.ObtenerProductos();
            return listado.Select(x=> x.ToDTO());

        }
    }
}
