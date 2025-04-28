using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Payments")]
    public class Payment{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentID {get; set;}

        [Required]
        [ForeignKey("Order")]
        public int OrderId {get;set;}

        public Order? Order {get;set;}

        [Required]
        [StringLength(100)]
        [Column(TypeName="nvarchar(100)")]
        public string PaymentMethod {get;set;}

        [Required]
        [StringLength(100)]
        [Column(TypeName="nvarchar(100)")]
        public string PaymentStatus {get;set;}

        [Required]
        [StringLength(100)]
        [Column(TypeName="nvarchar(100)")]
        public string TransactionId {get;set;}

        [Required]
        public decimal PaidAmount {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime PaidAt {get; set;} = DateTime.UtcNow;


    }
}