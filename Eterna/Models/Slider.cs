using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string BigText { get; set; }
        public string ColorText { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
