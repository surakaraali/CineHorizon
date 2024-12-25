using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using BCrypt.Net;

namespace MyWebApp.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public SignUpModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public string? Surname { get; set; }

        public string? ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var existingUser = _context.Users?.FirstOrDefault(u => u.Email == Email);
            if (existingUser != null)
            {
                ErrorMessage = "An account with this email already exists.";
                return Page();
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Password);

            var newUser = new User
            {
                Email = Email,
                Password = hashedPassword,
                Name = Name,
                Surname = Surname
            };

            _context.Users?.Add(newUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
