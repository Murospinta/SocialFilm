namespace SocialFilm;

public class Message
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public User Sender { get; set; }
    public User Receiver { get; set; }
}