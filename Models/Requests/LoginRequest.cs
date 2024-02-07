using System.ComponentModel.DataAnnotations;

public class LoginRequest
{
    [Required]
    public string Login {get; set;}
    [Required]
    [MinLength(8)]
    public string Password {get; set;}
}