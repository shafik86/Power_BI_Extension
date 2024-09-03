using System.ComponentModel.DataAnnotations;

namespace Power_BI_Extension.Models
{
    public class PBIDesign
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PbiUrl { get; set; }
        public int CatId { get; set; }
        

        [StringLength(maximumLength: 5000)]
        public string Thumb { get; set; } = "images/Thumbs/default.jpg";
    }
}
