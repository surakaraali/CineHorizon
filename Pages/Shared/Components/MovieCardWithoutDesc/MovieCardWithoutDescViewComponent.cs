using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models; 

namespace MyWebApp.Components
{
    public class MovieCardWithoutDescViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie);
        }
    }
}
