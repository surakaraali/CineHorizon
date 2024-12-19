namespace YourProject.Models
{
    public partial class Genre
    {
        public int Genreid { get; set; } // Tür ID'si
        public string? Name { get; set; } // Tür adı
         public virtual ICollection<Movie> Movies {get; set;} = new List<Movie>();
    }
}
