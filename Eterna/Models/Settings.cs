using System.Collections.Generic;

namespace Eterna.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string Gmail { get; set; }
        public string GmailIcon { get; set; }
        public string Phone { get; set; }
        public string PhoneIcon { get; set; }
        public List<HeaderSocialMedias> headerSocialMedias { get; set; }
        public List<FooterSocialMedias> FooterSocialMedias { get; set; }
    }
}
