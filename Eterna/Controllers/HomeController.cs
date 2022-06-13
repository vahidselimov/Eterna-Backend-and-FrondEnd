using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = context.Sliders.ToList();
            return View(sliders);
        }
    }
}
