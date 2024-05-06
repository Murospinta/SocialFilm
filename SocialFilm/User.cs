using Microsoft.AspNetCore.Identity;

namespace SocialFilm;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfileImage { get; set; }
    public string Bio { get; set; }
    public bool IsAdmin { get; set; }
    public List<User> Friends { get; set; }
    public List<Movie> Favourites { get; set; }
    public List<Movie> Watched { get; set; }
    public List<int> FavouriteGenres { get; set; }
}