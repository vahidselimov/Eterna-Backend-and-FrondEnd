using Microsoft.AspNetCore.Mvc;

namespace Eterna.Areas.EternaAdmin.Controllers
{
    [Area("EternaAdmin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
