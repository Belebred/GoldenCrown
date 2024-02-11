namespace GoldenCrown.Domain.Models.Database;
public class Account: Record
{
    public long UserId {get; set;}
    public double Amount {get; set;}
}