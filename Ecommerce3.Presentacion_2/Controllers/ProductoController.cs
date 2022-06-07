using Ecommerce3.Dominioo;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce3.Presentacion_2.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Nuevo()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Nuevo(ProductoDTO producto)
        {
            return View();
        }
    }
}
