using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_BookStoreUi.Models
{
    [Table("CardDetail")]
    public class CardDetail
    {
        public int Id { get; set; }


        [Required]
        public int ShoppingCardId { get; set; }

        public int BookId { get; set; }

        [Required]
        public int Quantity { get; set; }
        public Book Book { get; set; }

    
        public ShoppingCard ShoppingCard { get; set; }
    }
}
