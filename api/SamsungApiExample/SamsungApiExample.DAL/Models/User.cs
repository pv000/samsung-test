using System.ComponentModel.DataAnnotations;

namespace SamsungApiExample.DAL.Models;
public class User
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Email { get; set; } = string.Empty;
    public virtual Address? Address { get; set; }
}
