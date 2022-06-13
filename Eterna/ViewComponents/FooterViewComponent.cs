using Eterna.DAL;
using Eterna.Models;
using Eterna.Properties.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext context;

        public FooterViewComponent(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            Connect connect = await context.Connects.FirstOrDefaultAsync();
            FooterIcon footerIcons = await context.FooterIcons.FirstOrDefaultAsync();
            List<FooterSocialMedias> footerSocialMedias = await context.FooterSocialMedias.ToListAsync();
            List<HeaderSocialMedias> headerSocialMedias = await context.HeaderSocialMedias.ToListAsync();
            Settings setting = await context.Setting.FirstOrDefaultAsync();
            HomeVM HomeVM = new HomeVM
            {
               
                Connect = connect,
                FooterIcon = footerIcons,
                FooterSocialMedias = footerSocialMedias,
                headerSocialMedias = headerSocialMedias,
                Settings = setting

            };
            return View(HomeVM);
        }
    }
}
