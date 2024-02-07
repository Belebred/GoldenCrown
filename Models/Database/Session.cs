namespace GoldenCrown.Api.Models.Database;
public class Session: Record
{
    public long UserId {get; set;}
    public string? Token {get; set;}
    public DateTime ExpiredDate {get; set;}
}