using System;
using System.Collections.Generic;

namespace YourProject.Models
{
    public partial class Movie
    {
        public int Movieid { get; set; }  // Film ID'si, primary key
        public string? Title { get; set; } // Film başlığı
        public string? Description { get; set; } // Film açıklaması
        public string? Posterurl { get; set; } // Film afişi URL'si
        public double Rating { get; set; } // Film puanı
        public int Releaseyear { get; set; } // Çıkış yılı
        public string? Moviehour { get; set; } // Film süresi
        public string? Director { get; set; } // Yönetmen
        public string? Writer { get; set; } // Senarist
         public string? Trailer { get; set; } // Film fragmanı URL'si
        public virtual ICollection<Actor> Actors {get; set;} = new List<Actor>();

        public virtual ICollection<Genre> Genres {get; set;} = new List<Genre>();
        
        public string? Type {get; set;}
    }
}
