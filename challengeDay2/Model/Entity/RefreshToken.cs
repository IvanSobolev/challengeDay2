namespace challengeDay2.Model.Entity;

public class RefreshToken
{
    public string Token { get; set; }
    public string UserId { get; set; }
    public DateTime ExpiryDate { get; set; }
    
}