namespace SocialFilm;

public class Rating
{
    public int Id { get; set; }
    public User User { get; set; }
    public Movie Movie { get; set; }
    public int Value { get; set; }
    private DateTime Timestamp { get; set; }
}