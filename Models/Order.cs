using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Orders")]
    public class Order{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserID{get; set;}

        public User? User {get; set;}

        [Required]
        public decimal TotalAmount {get; set;}

        [Required]
        [StringLength(50)]
        [Column(TypeName="nvarchar(50)")]
        public string OderStatus {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatAt {get; set;} = DateTime.UtcNow;

    }
}