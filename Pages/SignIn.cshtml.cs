using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWebApp.Pages
{
using BCrypt.Net;
    public class SignInModel : PageModel
    {
        private readonly CineHorizonDbContext _context;

        public SignInModel(CineHorizonDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        public string? ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Please provide both Email and Password.";
                return Page();
            }

            var user = _context.Users?.FirstOrDefault(u => u.Email == Email);
            if (user == null || !BCrypt.Verify(Password, user.Password, false, hashType: HashType.SHA256))
            {
                ErrorMessage = "Invalid email or password.";
                return Page();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name!),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim("UserId", user.Uuid.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties
                {
                    IsPersistent = true, 
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(10) 
                });

            return RedirectToPage("/Index");
        }
    }
}
