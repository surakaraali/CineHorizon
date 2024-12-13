using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models;

namespace YourProject.Pages { 
public class MoviesModel : PageModel
{
    private readonly ILogger<MoviesModel> _logger;

    public MoviesModel(ILogger<MoviesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Movies = new List<Movie>
{

    //MOVIES PART IS BEGINNING HERE:
    //1-12. 

   new Movie(
        title: "The Godfather",
        description: "Michael, the young and idealistic son of Vito Corleone, the head of the most powerful Mafia clan in New York, returns home as a war hero and is determined to live his own life. But tragic circumstances make him face the legacy of his family.",
        posterUrl: "/img/godfather.jpeg",
        rating: 9.2,
        releaseYear: 1972,
        genres: new List<string> { "Gangster", "Tragedy", "Drama", "Crime" },
        movieHour: "2h 55m",
        director: "Francis Ford Coppola",
        writer: "Mario Puzo and Francis Ford Coppola",
        actors: new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
        trailer: "https://www.youtube.com/embed/sY1S34973zA"
    ),
    new Movie(
        title: "Fight Club",
        description: "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
        posterUrl: "/img/fight_club.jpeg",
        rating: 8.8,
        releaseYear: 1999,
        genres: new List<string> { "Drama", "Psychologic", "Action", "Adventure" },
        movieHour: "2h 19m",
        director: "David Fincher",
        writer: "Chuck Palahniuk and Jim Uhls",
        actors: new List<string> { "Brad Pitt", "Edward Norton", "Meat Loaf"},
        trailer: "https://www.youtube.com/embed/qtRKdVHc-cE"


    ),
    new Movie(
        title: "Cumhuriyet Şarkısı",
        description: "A thief who steals corporate secrets through dream-sharing technology.",
        posterUrl: "/img/cumhuriyet_sarkısı.jpg",
        rating: 8.8,
        releaseYear: 2010,
        genres: new List<string> { "Drama", "History", "Documentary", "Romantic" },
        movieHour: "2h 8m",
        director: "Yağız Alp Akaydın",
        writer: "BKM",
        actors: new List<string> { "Salih Bademci", "Birce Akalay", "Ertan Saban" },
        trailer:"https://www.youtube.com/embed/xC5zEa4VKhw"
    ),
    new Movie(
        title: "Matrix",
        description: "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
        posterUrl: "/img/matrix.jpeg",
        rating: 8.7,
        releaseYear: 1999,
        genres: new List<string> { "Action", "Sci-fi", "Epic", "Adventure" },
        movieHour: "2h 16m",
        director: "Lana Wachowski and Lilly Wachowski",
        writer: "Lana Wachowski and Lilly Wachowski",
        actors: new List<string> { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" },
        trailer:"https://www.youtube.com/embed/vKQi3bBA1y8"
    ),
    new Movie(
        title: "Panda Bear Africa",
        description: "A panda travels from China to Africa, facing hippos, hyenas, gorillas. He rescues his kidnapped dragon friend, makes new friends, and protects their jungle home.",
        posterUrl: "/img/panda_bear_africa.jpeg",
        rating: 5.5,
        releaseYear: 2024,
        genres: new List<string> { "Animation", "Family", "Comedy", "Adventure" },
        movieHour: "1h 24m",
        director: "Karsten Killerich and Richard Claus",
        writer: "Rob Sprackling",
        actors: new List<string> { "Maurits Delchot", "Thom Hoffman", "Silas Lekgoathi" },
        trailer:"https://www.youtube.com/embed/EQqaxagNUXw"
    ),
    new Movie(
        title: "Inside Out 2",
        description: "A sequel that features Riley entering puberty and experiencing brand new, more complex emotions as a result. As Riley tries to adapt to her teenage years, her old emotions try to adapt to the possibility of being replaced.",
        posterUrl: "/img/inside_out_2.jpeg",
        rating: 7.6,
        releaseYear: 2024,
        genres: new List<string> { "Animation", "Adventure", "Comedy", "Family" },
        movieHour: "1h 36m",
        director: "Kelsey Menn",
        writer: "Meg LeFauve and Dave Holstein",
        actors: new List<string> { "Amy Poehler", "Maya Hawke", "Kensington Tallman" },
        trailer:"https://www.youtube.com/embed/LEjhY15eCx0"
    ),
    new Movie(
        title: "Inside Out",
        description: "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.",
        posterUrl: "/img/inside_out.jpeg",
        rating: 8.1,
        releaseYear: 2015,
        genres: new List<string> { "Animation", "Adventure", "Comedy", "Family" },
        movieHour: "1h 35m",
        director: "Pete Docter and Ronnie Del Carmen",
        writer: "Pete Docter, Ronnie Del Carmen and Meg LeFauve",
        actors: new List<string> { "Amy Poehler", "Bill Hader", "Lewis Black" },
        trailer:"https://www.youtube.com/embed/1t0A_tZGrYw"
    ),
    new Movie(
        title: "Interstellar",
        description: "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
        posterUrl: "/img/interstellar.jpeg",
        rating: 8.7,
        releaseYear: 2014,
        genres: new List<string> { "Sci-fi", "Epic", "Adventure", "Drama" },
        movieHour: "2h 49m",
        director: "Christopher Nolan",
        writer: "Jonathan Nolan and Christopher Nolan",
        actors: new List<string> { "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain" },
        trailer:"https://www.youtube.com/embed/zSWdZVtXT7E"
    ),
    new Movie(
        title: "The Prestige",
        description: "Set in London in the 1800s, two rival magicians read each others diary containing the secrets of their magic tricks and personal life. As we go back in time when the diaries were written, both magicians become obsessed with their rival's best trick.",
        posterUrl: "/img/the_prestige.jpeg",
        rating: 8.5,
        releaseYear: 2006,
        genres: new List<string> { "Drama", "Mystery", "Sci-fi", "Thriller" },
        movieHour: "2h 10m",
        director: "Christopher Nolan",
        writer: "Jonathan Nolan and Christopher Priest",
        actors: new List<string> { "Christian Bale", "Hugh Jackman", "Scarlett Johansson" },
        trailer:"https://www.youtube.com/embed/RLtaA9fFNXU"
    ),
    new Movie(
        title: "The Silence of the Lambs",
        description: "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
        posterUrl: "/img/the_silence_of_the_lambs.jpeg",
        rating: 8.6,
        releaseYear: 1991,
        genres: new List<string> { "Psychological", "Thriller", "Drama", "Crime" },
        movieHour: "1h 58m",
        director: "Jonathan Demme",
        writer: "Thomas Harris and Ted Tally",
        actors: new List<string> { "Jodie Foster", "Anthony Hopkins", "Scott Glenn" },
        trailer:"https://www.youtube.com/embed/6iB21hsprAQ"
    ),
    new Movie(
        title: "The Star Wars",
        description: "After the Empire overpowers the Rebel Alliance, Luke Skywalker begins his Jedi training with Yoda. At the same time, Darth Vader and bounty hunter Boba Fett pursue his friends across the galaxy.",
        posterUrl: "/img/the_star_wars.jpeg",
        rating: 8.7,
        releaseYear: 1980,
        genres: new List<string> { "Sci-fi", "Epic", "Action", "Fantasy" },
        movieHour: "2h 4m",
        director: "Irvin Kershner",
        writer: "Leigh Brackett and Lawrence Kasdan George Lucas",
        actors: new List<string> { "Mark Hamill", "Harrison Ford", "Carrie Fisher" },
        trailer:"https://www.youtube.com/embed/JNwNXF9Y6kY"
    ),
    new Movie(
        title: "The Schindler's List",
        description: "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
        posterUrl: "/img/schindler_s_list.jpeg",
        rating: 9.0,
        releaseYear: 1993,
        genres: new List<string> { "Historical", "Epic", "Drama", "Biography" },
        movieHour: "3h 15m",
        director: "Steven Spielberg",
        writer: "Thomas Keneally and Steven Zaillian",
        actors: new List<string> { "Liam Neeson", "Ralph Fiennes", "Ben Kingsley" },
        trailer:"https://www.youtube.com/embed/gG22XNhtnoY"
    )
};
    }
} }