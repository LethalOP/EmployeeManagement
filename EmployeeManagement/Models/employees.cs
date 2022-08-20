using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class employees

    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public DateTime DOB { get; set; }
    }
}
