using System.Collections.Generic;
using System.Linq;

namespace SocialFilm;

public class Feed
{
    int Id { get; set; }
    List<Post> Posts { get; set; }
    
    /*public List<Post> GenerateFeed()
    {
        using (var context = new SocialFilmDbContext())
        {
            var latestPosts = context.Posts
                .OrderByDescending(p => p.Timestamp)
                .Take(10)
                .ToList();
            return latestPosts;
        }*/
}