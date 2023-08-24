using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMVC.Data.Entities
{
    [Table("tbl_product_review")]
    public class ProductReview
    {
        [ForeignKey("FK_tbl_products_tbl_product_review_ProductID")]
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey("FK_tbl_users_tbl_product_review_ProductID")]
        public int UserID { get; set; }

        public virtual User User { get; set; }

        public double Rating
        {
            get { return Rating; }
            set
            {
                Rating = value < 5 && value > 0 ? value : throw new InvalidDataException("Invalid Rating!");
            }
        }
    }

}