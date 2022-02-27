using System.ComponentModel.DataAnnotations;

namespace KatalogProizvoda.Models
{
    public class JednostavniProizvod
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Knjiga { get; set; }

        [Required]
        [StringLength(255)]
        public string CD { get; set; }

        [Required]
        [StringLength(255)]
        public string SmartTv { get; set; }

        [Required]
        [StringLength(255)]
        public string Smartphone { get; set; }

    }
}
