using Microsoft.AspNetCore.Mvc;
using System.Web;

using Ecommerce3.Dominioo;
using Ecommerce.Datos;
using Ecommerce3.Negocio;


namespace Ecommerce3.Presentacion_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }


        [HttpGet]
        public JsonResult ListarProducto()
        {
            List<ProductoDTO> listproducto = new List<ProductoDTO>();
            listproducto = new Producto().Listar();
            return Json(new { data = listproducto });
        }

        [HttpGet]
        public JsonResult ListarProductoImagen()
        {
            List<ImagenProductoDTO> listproductoImagen = new List<ImagenProductoDTO>();
            listproductoImagen = new Producto().Listar_Imagen();
            return Json(new { data = listproductoImagen });
        }

        [HttpGet]
        public JsonResult ListarCategoria()
        {
            List<CategoriaDTO> listcategoria = new List<CategoriaDTO>();
            listcategoria = new Categoria().Listar_Categoria();
            return Json(new { data = listcategoria });
        }

    }
}
