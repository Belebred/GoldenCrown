namespace GoldenCrown.Api.Models.Database;

public class User: Record
{
    public string? DisplayName {get; set;}
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
}