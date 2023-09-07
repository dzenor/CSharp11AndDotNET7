using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_BookStoreUi.Models
{
   
        [Table("Genre")]
        public class Genre
        {

            public int Id { get; set; }

            [Required]
            [MaxLength(40)]
      

            public int GenreName { get; set; }

            public List<Book> Books { get; set; }   
           


    }
    
}
