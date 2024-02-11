using System.ComponentModel.DataAnnotations;

namespace GoldenCrown.Domain.Models.Requests;
public class LoginRequest
{
    [Required]
    public string Login {get; set;}
    [Required]
    [MinLength(8)]
    public string Password {get; set;}
}