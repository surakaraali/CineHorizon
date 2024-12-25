using System;
using System.Collections.Generic;

namespace MyWebApp.Models  
{
    public partial class User
    {
        public int? Uuid { get; set; }
        public string? Email { get; set; }
        public string? Password {get; set;} 
        public string? Name {get; set;}
        public string? Surname {get; set;}
        public ICollection<MovieLike> LikedMovies { get; set; } = new List<MovieLike>();

    }
}