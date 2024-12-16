using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;
using System.Linq;

namespace MyWebApp.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public MovieDetailsModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public void OnGet(string id)
        {
            
            Movie = _context.Movies
                .Include(m => m.Genres) 
                .Include(m => m.Actors) 
                .FirstOrDefault(movie => movie.Title.Replace(" ", "-").ToLower() == id.ToLower());  

        }
    }
}
