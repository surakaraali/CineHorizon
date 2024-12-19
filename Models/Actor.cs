namespace YourProject.Models
{
    public partial class Actor
    {
        public int Actorid { get; set; } // Aktör ID'si
        public string? Name { get; set; } // Aktör adı
        public virtual ICollection<Movie> Movies {get; set;} = new List<Movie>();
    }
}
