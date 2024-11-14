namespace YourProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }

        public Movie(string title, string description, string posterUrl, double rating, int releaseYear)
        {
            Title = title;
            Description = description;
            PosterUrl = posterUrl;
            Rating = rating;
            ReleaseYear = releaseYear;
        }
    }
}
