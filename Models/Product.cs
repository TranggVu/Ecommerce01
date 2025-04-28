using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Products")]
    public class Product{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID {get; set;}
        
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name {get; set;}
        
        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Instock {get; set;}

        
        [Column(TypeName = "varchar(250)")]
        public string? ImageUrl {get; set;}

        [Required]
        [ForeignKey("Category")]
        public int CategoryId {get; set;}

        public Category? Category {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatAt {get; set;} = DateTime.UtcNow;


    }
}