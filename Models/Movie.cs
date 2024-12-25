using System;
using System.Collections.Generic;

namespace MyWebApp.Models 
{
    public partial class Movie
    {
        public int Movieid { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Posterurl { get; set; }
        public double? Rating { get; set; }
        public int? Releaseyear { get; set; }
        public string? Moviehour { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Trailer { get; set; }
        public virtual ICollection<Actor> Actors { get; set; } = new List<Actor>();
        public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public string? Type { get; set; }
        public ICollection<MovieLike> MovieLikes { get; set; } = new List<MovieLike>();

    }
}
