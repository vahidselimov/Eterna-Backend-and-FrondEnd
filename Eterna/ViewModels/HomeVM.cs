using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.Properties.ViewModels
{
    public class HomeVM
    {
        public Connect Connect { get; set; }
        public AnotherSettings AnotherSettings { get; set; }
        public FooterIcon FooterIcon { get; set; }
        public List<FooterSocialMedias> FooterSocialMedias { get; set; }
        public List<HeaderSocialMedias> headerSocialMedias { get; set; }
        public Settings Settings { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
