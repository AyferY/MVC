using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
