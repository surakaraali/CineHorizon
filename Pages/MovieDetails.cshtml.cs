using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YourProject.Models;

namespace YourProject.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public MovieDetailsModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        public Movie? Movie { get; set; }

        public void OnGet(string id)

        {
           Movie = _context.Movies
           .Include(m=> m.Genres)
           .Include(m=>m.Actors)
           .FirstOrDefault(Movie=> Movie.Title.Replace(" ","-").ToLower()== id.ToLower());

        }
    }
}
