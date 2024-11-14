using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models;

namespace YourProject.Pages
{
    public class MovieDetailsModel : PageModel
    {
        public Movie Movie { get; set; }

        private static List<Movie> Movies = new List<Movie>
        {
            new Movie("Cumhuriyet Şarkısı", "A thief who steals corporate secrets through dream-sharing technology.", "/img/cumhuriyet_sarkısı.jpg", 8.8, 2010),
            new Movie("Venom", "The origin story of the anti-hero Venom.", "/img/venom.jpg", 7.0, 2018),
            new Movie("Cesur Panda", "A computer hacker learns about the true nature of reality.", "/img/cesur_panda.jpg", 8.7, 1999),
            new Movie("Ters Yüz 2", "A robot stranded in the wild learns to survive.", "/img/ters_yüz_2.jpg", 8.5, 2017),
            new Movie("Ters Yüz 3", "A robot stranded in the wild learns to survive.", "/img/ters_yüz_2.jpg", 8.5, 2017)
        };

        public void OnGet(string id)
        {
            Movie = Movies.FirstOrDefault(m => m.Title.Replace(" ", "-").ToLower() == id.ToLower());
        }
    }
}
