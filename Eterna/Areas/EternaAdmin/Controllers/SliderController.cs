using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eterna.Utilities;
using Eterna.Extensions;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Eterna.Areas.EternaAdmin.Controllers
{
    [Area("EternaAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public SliderController(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }
       
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }
       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult>Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slider.Photo!=null)
            {
                if (slider.Photo.IsOkey(1))
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
                string fileName = slider.Photo.FileName;
                string path = Path.Combine(webHost.WebRootPath, "image");
                slider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\image");
                await context.Sliders.AddAsync(slider);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }

        }
        public async Task<ActionResult>Detail(int id)
        {
            Slider slider=await context.Sliders.FirstOrDefaultAsync(s=>s.Id==id);
            if (slider==null)
            {
                return NotFound();

            }
            return View(slider);    
        }
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSize(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();

            context.Sliders.Remove(slider);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
