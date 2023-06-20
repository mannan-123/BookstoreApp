using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,50)]
        public int DisplayOrder { get; set; }
    }
}
