using Microsoft.AspNetCore.Mvc;

namespace PostAjax.Controllers
{
    public class ProductoController : Controller
    {
        private static List<string> _productos = new List<string>
        {
            "Pan",
            "Té verde",
            "Galletas"
        };

        public IActionResult Index()
        {
            return View(_productos);
        }

        [HttpPost]
        public IActionResult Agregar(string nombre)
        {
            _productos.Add(nombre);
            return Json(new { success = true });
        }
        [HttpPost]
        public IActionResult Eliminar(string nombre)
        {
            _productos.Remove(nombre);
            return Json(new { success = true });
        }
    }
}
