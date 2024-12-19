using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models;
using System.Collections.Generic;

namespace YourProject.Pages
{
    public class SeriesLayoutModel : PageModel
    {
      private readonly CineHorizonDbContext _context;

        public SeriesLayoutModel(CineHorizonDbContext context)
        {
            _context = context;
        }


        public List<Movie>? Movies { get; set; }

        public void OnGet()
        {
            Movies = _context.Movies
                .Where(movie => movie.Type == "series")
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

