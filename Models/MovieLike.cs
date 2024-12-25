
namespace MyWebApp.Models
{
    public class MovieLike
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual User? User { get; set; }

    }


}
