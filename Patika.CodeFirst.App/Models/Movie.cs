using System.ComponentModel.DataAnnotations;

namespace Patika.CodeFirst.App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Genre { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
    }
}
