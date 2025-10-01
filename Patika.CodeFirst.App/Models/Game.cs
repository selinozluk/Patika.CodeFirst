using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Patika.CodeFirst.App.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Platform { get; set; } = string.Empty;
        [Range(0, 10)]
        [Precision(3, 1)] // 0.0 - 10.0 aralığı için (toplam 3 hane, virgülden sonra 1)
        public decimal Rating { get; set; }
    }
}
