using System.ComponentModel.DataAnnotations;

namespace QueroServicos.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public virtual List<Subcategory>? Subcategories { get; set; }
    }
    public class Subcategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
