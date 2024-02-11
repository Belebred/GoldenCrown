using System.ComponentModel.DataAnnotations;

namespace GoldenCrown.Domain.Models.Requests;
public class RegisterRequest
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string DisplayName { get; set; }
}