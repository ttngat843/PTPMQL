using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Employee : Person
    {
        [Required]
        public int EmployeeID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}