using System.ComponentModel.DataAnnotations;

namespace WebApk2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
