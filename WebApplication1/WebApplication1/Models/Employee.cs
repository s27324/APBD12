using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Employee
{
    [Key] public int IdEmp { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("First name")]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("Last name")]
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("Addres")]
    public string Address { get; set; }
    
    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; }
}