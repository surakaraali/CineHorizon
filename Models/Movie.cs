namespace YourProject.Models
{
    using System.Collections.Generic;

    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }
        public List<string> Genres { get; set; } // Genres artık bir liste
        public string MovieHour { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public List<string> Actors { get; set; } // Actors da bir liste oldu

        public Movie(string title, string description, string posterUrl, double rating, int releaseYear, List<string> genres, string movieHour, string director, string writer, List<string> actors)
        {
            Title = title;
            Description = description;
            PosterUrl = posterUrl;
            Rating = rating;
            ReleaseYear = releaseYear;
            Genres = genres;
            MovieHour = movieHour;
            Director = director;
            Writer = writer;
            Actors = actors;
        }
    }
}


    
