namespace SocialFilm;

public class Notification
{
    public int Id { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public bool IsRead { get; set; }
}