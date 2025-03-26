namespace challengeDay2.Model.Entity;

public class Order
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}