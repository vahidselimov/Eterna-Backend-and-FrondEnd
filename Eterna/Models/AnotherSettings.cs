using System.Collections.Generic;

namespace Eterna.Models
{
    public class AnotherSettings
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public List<FooterSocialMedias> FooterSocialMedias { get; set; }
        public List<HeaderSocialMedias> HeaderSocialMedias { get; set; }
      
    }
}
