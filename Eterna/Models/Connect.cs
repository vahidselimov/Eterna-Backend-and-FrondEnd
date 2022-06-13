using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Connect
    {
        public int Id { get; set; }
        [Required]
        public string GmailUrl { get; set; }
        [Required]
        public string PhoneUrl { get; set; }
        [Required]
        public string Gmail { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
