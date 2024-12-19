using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models;
using System.Collections.Generic;


namespace YourProject.Pages
{
    public class IndexModel : PageModel
    {

        private readonly CineHorizonDbContext _context;

        public IndexModel (CineHorizonDbContext context)
        {
            _context = context;

        }
        
        public List<Movie> ? Movies { get; set; }

        public void OnGet()
        {
            Movies = _context.Movies
                .Select(movie => new Movie
                {
                    Movieid = movie.Movieid,
                    Title = movie.Title,
                    Description = movie.Description,
                    Posterurl = movie.Posterurl,
                    Rating = movie.Rating,
                    Releaseyear = movie.Releaseyear,
                    Moviehour = movie.Moviehour,
                    Director = movie.Director,
                    Writer = movie.Writer,
                    Trailer = movie.Trailer
                })
                .ToList();
        }
    }
}