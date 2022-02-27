using System.ComponentModel.DataAnnotations;

namespace KatalogProizvoda.Models
{
    public class ProizvodZaPreuzimanje
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Fotografija { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Video { get; set; }
        
        [Required]
        [StringLength(200)]
        public string OperativniSustav { get; set; }
        
        [Required]
        [StringLength(255)]
        public string WebAplikacija { get; set; }
    }
}
