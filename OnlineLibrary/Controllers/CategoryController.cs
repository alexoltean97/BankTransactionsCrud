using Microsoft.AspNetCore.Mvc;

namespace OnlineLibrary.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
