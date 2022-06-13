using Eterna.DAL;
using Eterna.Models;
using Eterna.Properties.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AnotherSettings anotherSettings = await dbContext.Settings.FirstOrDefaultAsync();
            Connect connect = await dbContext.Connects.FirstOrDefaultAsync();
            FooterIcon footerIcons = await dbContext.FooterIcons.FirstOrDefaultAsync();
            List<FooterSocialMedias> footerSocialMedias = await dbContext.FooterSocialMedias.ToListAsync();
            List<HeaderSocialMedias> headerSocialMedias = await dbContext.HeaderSocialMedias.ToListAsync();
            Settings setting = await dbContext.Setting.FirstOrDefaultAsync();
            HomeVM homeVM = new HomeVM
            {
                AnotherSettings = anotherSettings,
                Connect = connect,
                FooterIcon = footerIcons,
                FooterSocialMedias = footerSocialMedias,
                headerSocialMedias = headerSocialMedias,
                Settings=setting
               
            };
            return View(homeVM);


        }
    }
}
