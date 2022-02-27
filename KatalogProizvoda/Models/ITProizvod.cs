using System.ComponentModel.DataAnnotations;

namespace KatalogProizvoda.Models
{
    public class ITProizvod
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Miš { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Tipkovnica { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Slušalice { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Zvučnik { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Kamera { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Laptop { get; set; }
        
        [Required]
        [StringLength(255)]
        public string PC { get; set; }
    }
}
