namespace SocialFilm;

public class Movie
{ 
        public int Id { get;  set; } 
        public int Title { get; set; } 
        public int ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public string PosterImage { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Directors { get; set; }
        public List<string> Cast { get; set; } 
        public double Rating { get; set; } 
        public List<Post> Posts { get; set; }
}
