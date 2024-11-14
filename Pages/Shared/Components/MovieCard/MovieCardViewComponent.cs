using Microsoft.AspNetCore.Mvc;
using YourProject.Models; 

namespace YourProject.Components
{
    public class MovieCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie); 
        }
    }
}
