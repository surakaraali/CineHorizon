// namespace YourProject.Models
// {
//     public class Movie
//     {
//         public int MovieId { get; set; }  // Film ID'si, primary key
//         public string? Title { get; set; } // Film başlığı
//         public string? Description { get; set; } // Film açıklaması
//         public string? PosterUrl { get; set; } // Film afişi URL'si
//         public double Rating { get; set; } // Film puanı
//         public int ReleaseYear { get; set; } // Çıkış yılı
//         public string? MovieHour { get; set; } // Film süresi
//         public string? Director { get; set; } // Yönetmen
//         public string? Writer { get; set; } // Senarist
//          public string? Trailer { get; set; } // Film fragmanı URL'si
//         public List<MovieGenre>? MovieGenres { get; set; } // Film ile ilgili türler
//         public List<MovieActor>? MovieActors { get; set; } // Filmdeki oyuncular
//     }
// }

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
        public string Trailer { get; set; }
        public List<string> Actors { get; set; } // Actors da bir liste oldu

        public Movie(string title, string description, string posterUrl, double rating, int releaseYear, List<string> genres, string movieHour, string director, string writer, List<string> actors,string trailer)
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
            Trailer = trailer;
        }
    }
}


    
