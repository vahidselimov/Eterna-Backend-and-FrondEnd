namespace Eterna.Models
{
    public class FooterSocialMedias
    {
        public int Id { get; set; }
        public string FooterSocialMediasUrl { get; set; }
        public AnotherSettings AnotherSettings { get; set; }
        public int? AnotherSettingsId { get; set; }
        public Settings Settings { get; set; }
        public int? SettingsId { get; set; }
    }
}
