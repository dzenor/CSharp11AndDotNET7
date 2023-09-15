using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_BookStoreUi.Models
{
    [Table("ShoppingCard")]
    public class ShoppingCard
    {
        public int Id { get; set; }

        [Required]
        public string  UserId { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<CardDetail> CartDetails { get; set; }
    }
}
