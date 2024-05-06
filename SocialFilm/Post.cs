namespace SocialFilm;

public class Post
{
    public int Id { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public Movie Movie { get; set; }
    public List<Comment> Comments { get; set; }//??
    public List <User> Likes { get; set; }
    
    public Post(User user, string content, DateTime timestamp)
    {
        User = user;
        Content = content;
        Timestamp = timestamp;
        Comments = new List<Comment>();
    }
}