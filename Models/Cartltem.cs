using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Cartltems")]
    public class Cartltem{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartltemID {get; set;}

        [Required]
        [ForeignKey("User")]
        public int UserID{get;set;}

        public User? User {get;set;}

        [Required]
        [ForeignKey("Product")]
        public int ProductID{get;set;}

        public Product? Product {get;set;}

        [Required]
        public int Quantity {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatAt {get; set;} = DateTime.UtcNow;



    }
}