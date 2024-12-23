using Microsoft.AspNetCore.Mvc;
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

        public Movie? Movie { get; set; }

        public IList<Comment> Comments { get; set; } = new List<Comment>();

        [BindProperty]
        public int MovieId { get; set; }

        [BindProperty]
        public string? CommentContent { get; set; }


        public void OnGet(string id)
        {
            if (_context.Movies != null)
            {
                Movie = _context.Movies
                    .Include(m => m.Genres)
                    .Include(m => m.Actors)
                    .FirstOrDefault(movie => movie.Title.Replace(" ", "-").ToLower() == id.ToLower());

                if (Movie != null && _context.Comments != null)
                {
                    MovieId = Movie.Movieid;
                    Comments = _context.Comments
                        .Where(c => c.MovieId == Movie.Movieid)
                        .OrderByDescending(c => c.CreatedAt)
                        .ToList();
                }
            }
            else
            {
                Movie = null;
                Comments = new List<Comment>();
            }
        }


        public IActionResult OnPost()
        {
            Console.WriteLine($"MovieId: {MovieId}");
            Console.WriteLine($"CommentContent: {CommentContent}");

            if (!ModelState.IsValid)
            {
                return Page();
            }
            

            var movie = _context.Movies?.Find(MovieId);
            if (movie == null)
            {
                return RedirectToPage("/Error");
            }

            var comment = new Comment
            {
                MovieId = MovieId,
                Content = CommentContent,
                CreatedAt = DateTime.UtcNow
            };

            _context.Comments?.Add(comment);
            _context.SaveChanges();

            return RedirectToPage(new { id = movie.Title.Replace(" ", "-").ToLower() });
        }



    }
}
