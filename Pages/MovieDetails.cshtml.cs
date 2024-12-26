using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;
using System.Linq;
using System.Security.Claims;
using System;
using System.Collections.Generic;

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
        public IList<Comment>? Comments { get; set; } = new List<Comment>();
        public IList<User>? Likers { get; set; } = new List<User>();

        [BindProperty]
        public int MovieId { get; set; }

        [BindProperty]
        public string? CommentContent { get; set; }

        public void OnGet(string id)
        {
            Movie = _context.Movies?
                .Include(m => m.Genres)
                .Include(m => m.Actors)
                .Include(m => m.MovieLikes)
                .ThenInclude(ml => ml.User)
                .FirstOrDefault(movie => movie.Title.Replace(" ", "-").ToLower() == id.ToLower());

            if (Movie != null)
            {
                MovieId = Movie.Movieid;
                Comments = _context.Comments?
                   .Include(c => c.User) 
                   .Where(c => c.MovieId == Movie.Movieid)
                   .OrderByDescending(c => c.CreatedAt)
                   .ToList();

                Likers = _context.MovieLikes?
                    .Where(ml => ml.MovieId == Movie.Movieid)
                    .Select(ml => new User { Uuid = ml.User.Uuid, Name = ml.User.Name }) 
                    .ToList();
            }
            else
            {
                Comments = new List<Comment>();
                Likers = new List<User>();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movie = _context.Movies?.Find(MovieId);
            if (movie == null)
            {
                return RedirectToPage("/Error");
            }

            var userId = User?.FindFirstValue("UserId");
            if (userId == null)
            {
                return RedirectToPage("/SignIn");
            }

            if (!int.TryParse(userId, out int parsedUserId))
            {
                return RedirectToPage("/Error");
            }

            var comment = new Comment
            {
                MovieId = MovieId,
                Content = CommentContent,
                CreatedAt = DateTime.UtcNow,
                UserId = parsedUserId
            };

            _context.Comments?.Add(comment);
            _context.SaveChanges();

            return RedirectToPage(new { id = movie.Title.Replace(" ", "-").ToLower() });
        }

        public IActionResult OnPostLike()
        {
            var userId = User?.FindFirstValue("UserId");
            if (userId == null)
            {
                return RedirectToPage("/SignIn");
            }

            if (!int.TryParse(userId, out int parsedUserId))
            {
                throw new InvalidOperationException("Unable to parse user ID.");
            }

            var movie = _context.Movies?.FirstOrDefault(m => m.Movieid == MovieId);
            if (movie == null)
            {
                return RedirectToPage("/Error");
            }

            var existingLike = _context.MovieLikes?
                .FirstOrDefault(ml => ml.MovieId == MovieId && ml.UserId == parsedUserId);
                
            if (existingLike == null)
            {
                var movieLike = new MovieLike
                {
                    MovieId = MovieId,
                    UserId = parsedUserId
                };
                _context.MovieLikes?.Add(movieLike);
            }
            else
            {
                _context.MovieLikes?.Remove(existingLike);
            }

            _context.SaveChanges();

            return RedirectToPage(new { id = movie.Title.Replace(" ", "-").ToLower() });
        }
    }
}
