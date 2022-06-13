using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eterna.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext context;

        public ServicesController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            Connect connect = context.Connects.FirstOrDefault();
            return View(connect);
        }
    }
}
