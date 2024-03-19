using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CustomerDemo.Data;
using CustomerDemo.Model;

namespace CustomerDemo.Model
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required (ErrorMessage ="Name is  Requried")]
        [MaxLength(100)]
        [MinLength(10)]
        public string Name { get; set; }

       
        public string Email { get; set; }
        
        public string Phone { get; set; }

    }
}
