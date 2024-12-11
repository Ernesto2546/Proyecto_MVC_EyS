using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace EyS_Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; init; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Category Name")]
        public string Name { get; init; }
        [DisplayName("Display Order")]
        [Range(1,150,ErrorMessage ="Display Order must be between 1-150")]
        public int DisplayOrder { get; init; }

    }
}
