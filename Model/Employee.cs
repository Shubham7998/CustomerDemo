using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDemo.Model
{
    [Table("Employee")]
    public class Employee
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Required]
        [MaxLength(30)]
        public string EmpName { get; set; }
        [Required]
        [MaxLength(10)]
        public string EmpTotal { get; set; }
    }
}
