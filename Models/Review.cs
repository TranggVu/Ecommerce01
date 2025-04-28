using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Reviews")]
    public class Review{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity :id tự tạo
        public int ReviewId {get; set;}

        [Required]
        [ForeignKey("User")]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Username {get; set;}

        [Required]
        [ForeignKey("Product")]
        public int ProductID {get; set;}

        public Product? Product{get;set;}

        [Required]
        public int Rating {get; set;}

        [Required]
        [StringLength(1000)]
        [Column(TypeName="varchar(1000)")]
        public string Comment {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatAt {get; set;} = DateTime.UtcNow;
    }
}