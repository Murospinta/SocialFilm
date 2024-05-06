namespace SocialFilm;

public class Chat
{
    public int Id { get; set; }
    public List<User> Participants { get; set; }
    public List<Message> Messages { get; set; }
}