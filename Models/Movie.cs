namespace YourProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genres { get; set; }
        public string Genres1 { get; set; }
        public string Genres2 { get; set; }
        public string Genres3 { get; set; } 
        public string MovieHour { get; set; }
        public string Director{ get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Actors1 { get; set; }
        public string Actors2 { get; set; }


        public Movie(string title, string description, string posterUrl, double rating, int releaseYear, string genres, string genres1, string genres2, string genres3, string movieHour,string director,string writer, string actors, string actors1,string actors2)
        {
            Title = title;
            Description = description;
            PosterUrl = posterUrl;
            Rating = rating;
            ReleaseYear = releaseYear;
            Genres = genres; 
            Genres1=genres1;
            Genres2=genres2;
            Genres3=genres3;
            MovieHour=movieHour;
            Director =director;
            Writer=writer;
            Actors=actors;
            Actors1=actors1;
            Actors2=actors2;
        }
    }
}
