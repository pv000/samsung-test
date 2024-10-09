using System.ComponentModel.DataAnnotations;

namespace SamsungApiExample.DAL.Models;
public class Address
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }

    [MaxLength(50)]
    public string City { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Country { get; set; } = string.Empty;
    [MaxLength(500)]
    public string Street { get; set; } = string.Empty;
    [MaxLength(10)]
    public string ZipCode { get; set; } = string.Empty;
}
