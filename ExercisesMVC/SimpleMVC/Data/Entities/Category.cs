using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMVC.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Text too long")]
        public string? CategoryName { get; set; }

        [StringLength(250)]
        public string? CategoryDescription { get; set; }

        [StringLength(50)]
        public string? ImageName { get; set; }

    }
}