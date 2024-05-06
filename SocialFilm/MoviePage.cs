namespace SocialFilm;

public class MoviePage
{
    public int Page { get; set; }
    public List<Movie> Results { get; set; }
    public int TotalPages { get; set; }
}