using Microsoft.AspNetCore.Mvc;
using YourProject.Models; // Movie modelini içeren namespace

namespace YourProject.Components
{
    public class MovieCardWithoutDescViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie); // Razor dosyasına göndermek için
        }
    }
}
