namespace GoldenCrown.Domain.Models.Database;
public class Transaction: Record
{
    public long SenderId {get; set;}
    public long RecieverId {get; set;}
    public double Amount {get; set;}
    public DateTime SendDate {get; set;}
    public DateTime? RecieveDate {get; set;}
}