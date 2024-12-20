using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.Pages
{
    public class MoviesLayoutModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public MoviesLayoutModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        public List<Movie>? Movies { get; set; }

        public void OnGet()
        {
            if (_context.Movies != null)
            {
                Movies = _context.Movies
                    .Where(movie => movie.Type == "movie")
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
                        Trailer = movie.Trailer,
                        Type = movie.Type
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

