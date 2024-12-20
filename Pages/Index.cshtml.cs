using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public IndexModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        public List<Movie>? Movies { get; set; }

        public void OnGet()
        {
            if (_context.Movies != null)
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
    else
    {
        Movies = new List<Movie>();
    }
        }
    }
}
