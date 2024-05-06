using Microsoft.EntityFrameworkCore;
namespace SocialFilm;

public class SocialFilmContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Feed> Feeds { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MoviePage> MoviePages { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=gamedata.db");
    }

}