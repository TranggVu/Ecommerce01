using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("OrderDetails")]
    public class OrderDetail{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetail {get; set;}

        [Required]
        [ForeignKey("Order")]
        public int OrderId {get; set;}

        public Order? Order {get;set;}

        [Required]
        [ForeignKey("Product")]
        public int ProductID {get; set;}
        public Product? Product {get;set;}

        [Required]
        public int Quantity {get; set;}

        [Required]
        public decimal Price {get;set;}

    }
}