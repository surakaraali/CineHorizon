using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models;
using System.Collections.Generic;

namespace YourProject.Pages
{
    public class SeriesLayoutModel : PageModel
    {
        public List<Movie>? Movies { get; set; }

        public void OnGet()
        {

            Movies = new List<Movie>
{

         new Movie(
        title: "Blue Planet 2",
        description: "Nearly a generation after the acclaimed Blue Planet documentary was released, David Attenborough returns to narrate this groundbreaking sequel/reboot. Blue Planet ll focuses more heavily on mankind's influence on the world's oceans through both global pollution and climate change. This series features a variety of revolutionary segments never before seen in a video documentary, including: cuttlefish that hypnotize crabs to stun them, giant trevally that leap out of the water to catch low flying birds, and newly discovered dancing yeti crabs.",
        posterUrl: "/img/blue_planet_2.jpg",
        rating: 9.3,
        releaseYear: 2017,
        genres: new List<string> { "Nature Documentary", "Documentary"},
        movieHour: "50m",
        director: "James Honeyborne",
        writer: "David Attenborough",
        actors: new List<string> { "Marine Animals"},
        trailer:"https://www.youtube.com/embed/kAphgHhlteM"
    ),

     new Movie(
        title: "Death Note",
        description: "Death Note follows the story of Light Yagami, an extraordinarily intelligent high school student who stumbles upon a mysterious notebook dropped by a shinigami (death god) named Ryuk. This notebook, known as the Death Note, has the terrifying ability to kill anyone whose name is written in it, as long as the writer knows the person's face. Driven by his desire to create a utopian world free of crime and corruption, Light begins eliminating criminals under the alias Kira.",
        posterUrl: "/img/death_note.jpg",
        rating: 9.0,
        releaseYear: 2006,
        genres: new List<string> { "Crime", "Mystery","Thriller","Supernatural"},
        movieHour: "20m, 37 episodes",
        director: "Tetsurō Araki",
        writer: "Tsugumi Ohba",
        actors: new List<string> { "Mamoru Miyano ","Kappei Yamaguchi ","Shido Nakamura"},
        trailer:"https://www.youtube.com/embed/gvxNaSIB_WI"
    ),

     new Movie(

        title: "Bluey",
        description: "Bluey is a lovable Blue Heeler puppy who uses her imagination, creativity, and boundless energy to explore life with her family and friends.",
        posterUrl: "/img/bluey.jpg",
        rating: 9.6,
        releaseYear: 2018,
        genres: new List<string> { "Animation", "Family","Comedy"},
        movieHour: "7 seasons, 52 episodes per season",
        director: "Joe Brumm",
        writer: "Joe Brumm",
        actors: new List<string> { "Dave McCormack","Melanie Zanetti "},
        trailer: "https://www.youtube.com/embed/2ZtG5Ba6iT0"

     ),

       new Movie(

        title: "Friends",
        description: "Friends is a timeless sitcom that follows the lives, relationships, and comedic misadventures of six friends living in New York City. Monica Geller, a chef with a penchant for cleanliness, shares an apartment with her quirky and upbeat childhood friend, Rachel Green, who is adjusting to life after leaving her wealthy background. Across the hall lives Chandler Bing, known for his sarcastic humor, and Joey Tribbiani, a struggling actor with a big heart. Adding to the dynamic are Ross Geller, Monica's nerdy yet endearing paleontologist brother, and Phoebe Buffay, an eccentric musician with a colorful personality.",
        posterUrl: "/img/friends.jpeg",
        rating: 8.9,
        releaseYear: 1994,
        genres: new List<string> { "Comedy", "Romance"},
        movieHour: "22 min, 236 episodes total",
        director: "James Burrows and Gary Halverson",
        writer: "Marta Kauffman",
        actors: new List<string> { "Jennifer Aniston","Courteney Cox","Lisa Kudrow","Matt LeBlanc","Matthew Perry","David Schwimmer"},
        trailer: "https://www.youtube.com/embed/s2TyVQGoCYo"

     ),

       new Movie(

        title: "Game of Thrones",
        description: "Set in the fictional continents of Westeros and Essos, Game of Thrones is a fantasy drama series based on George R.R. Martin’s A Song of Ice and Fire novels. The show centers around several noble families fighting for control of the Iron Throne and the Seven Kingdoms of Westeros. As political intrigue, power struggles, and betrayals unfold, characters navigate a dangerous world where loyalty is fleeting and alliances are temporary. Alongside the power struggles of the human factions, the ancient threats of magic, dragons, and the undead grow ever stronger.",
        posterUrl: "/img/game_of_thrones.jpeg",
        rating: 9.3,
        releaseYear: 2011,
        genres: new List<string> { "Action", "Adventure","Drama","Fantasy"},
        movieHour: "60 min, 73 episodes total",
        director: "David Nutter",
        writer: "George R.R. Martin ",
        actors: new List<string> { "Emilia Clarke","Kit Harington","Peter Dinklage","Lena Headey","Nikolaj Coster-Waldau","Maisie Williams","Sophie Turner"},
        trailer: "https://www.youtube.com/embed/bjqEWgDVPe0"

     ),

        new Movie(

       title: "Gibi",
       description: "Gibi is a Turkish comedy series that follows the absurd and hilarious misadventures of two best friends, Yılmaz and İlkkan, as they navigate life's peculiar challenges. Their unique perspective and dry humor turn ordinary situations into laugh-out-loud moments, making it a fresh and relatable exploration of modern life.",
       posterUrl: "/img/gibii.jpg",
       rating: 9.1,
       releaseYear: 2021,
       genres: new List<string> {"Comedy", "Drama"},
       movieHour: "3 seasons, 10 episodes per season",
       director: "Onur Ünlü",
       writer: "Aziz Kedi, Feyyaz Yiğit",
       actors: new List<string> {"Feyyaz Yiğit", "Kıvanç Kılıçaslan","Ahmet Kürşat Öçalan"},
       trailer: "https://www.youtube.com/embed/FNHsd-JKpFk"

    ),

       new Movie(

       title: "Leyla ile Mecnun",
       description: "Leyla ile Mecnun is a surreal and comedic Turkish TV series that tells the story of Mecnun, a hopeless romantic, and his love for Leyla. Blending absurd humor, fantasy, and heartfelt moments, the show explores friendship, family, and love in a quirky and imaginative way. It has gained a cult following for its unique storytelling and memorable characters.",
       posterUrl: "/img/leyla_ile_mecnun.jpg",
       rating: 9.3,
       releaseYear: 2011,
       genres: new List<string> {"Comedy", "Drama", "Fantasy"},
       movieHour: "3 seasons, 104 episodes",
       director: "Onur Ünlü",
       writer: "Burak Aksak",
       actors:  new List <string> {"Ali Atay", "Serkan Keskin", "Ahmet Mümtaz Taylan", "Cengiz Bozkurt", "Melis Birkan"},
       trailer: "https://www.youtube.com/embed/-Rdutc-MOV4"

    ),

      new Movie(

       title: "Breaking Bad",
       description: "Breaking Bad is a critically acclaimed crime drama that follows Walter White, a high school chemistry teacher turned methamphetamine manufacturer, after being diagnosed with terminal cancer. Partnering with his former student Jesse Pinkman, Walter's descent into the criminal underworld challenges his morality and transforms his life in ways he never imagined. The series is renowned for its intense storytelling, complex characters, and gripping drama.",
       posterUrl: "/img/the_breaking_bad.jpeg",
       rating: 9.5,
       releaseYear: 2008,
       genres: new List<string>{"Crime", "Drama", "Thriller"},
       movieHour: "3 seasons, 104 episodes",
       director: "Vince Gilligan",
       writer: "Vince Gilligan",
       actors: new List<string> {"Bryan Cranston", "Aaron Paul", "Anna Gunn", "Dean Norris", "Bob Odenkirk", "Giancarlo Esposito"},
       trailer: "https://www.youtube.com/embed/HhesaQXLuRY"


    ),

    
      new Movie(

       title: "Narcos",
       description: "Narcos is a gripping crime drama that chronicles the rise of drug cartels in Colombia during the 1980s and 1990s. The series delves into the lives of key figures like Pablo Escobar, along with the efforts of law enforcement agencies to dismantle these powerful organizations. With its intense storytelling, thrilling action, and exploration of the dark world of narcotics, Narcos remains a critically acclaimed and highly binge-worthy series.",
       posterUrl: "/img/the_narcos.jpg",
       rating: 8.8,
       releaseYear: 2015,
       genres: new List<string>{"Crime", "Drama", "Thriller"},
       movieHour: "3 seasons, 30 episodes per season",
       director: "Andrés Baiz, Fernando Coimbra",
       writer: "Carlo Bernard, Chris Brancato",
       actors: new List<string> {"Wagner Moura", "Boyd Holbrook", "Pedro Pascal", "Joanna Christie", "Maurice Compte" },
       trailer: "https://www.youtube.com/embed/xl8zdCY-abw"

    ),

        new Movie(

       title: "The Office",
       description: "he Office is a mockumentary-style sitcom that takes a humorous look at the everyday lives of office employees at the Dunder Mifflin Paper Company in Scranton, Pennsylvania. With a quirky cast, awkward situations, and memorable one-liners, the series explores the challenges and absurdities of the modern workplace in an entertaining and relatable way.",
       posterUrl: "/img/the_office.jpeg",
       rating: 9.0,
       releaseYear: 2005,
       genres: new List<string>{"Comedy", "Mockumentary"},
       movieHour: "9 seasons, 201 episodes",
       director: "Greg Daniels",
       writer: "Greg Daniels, Ricky Gervais, Stephen Merchant",
       actors: new List<string> {"Steve Carell", "Rainn Wilson", "John Krasinski", "Jenna Fischer", "Mindy Kaling", "Ed Helms"},
       trailer: "https://www.youtube.com/embed/-C2z-nshFts"

    ),

      new Movie(

       title: "The Simpsons",
       description: "The Simpsons is an iconic animated sitcom that follows the everyday life of the Simpson family—Homer, Marge, Bart, Lisa, and Maggie—in the fictional town of Springfield. Known for its satirical humor, social commentary, and memorable characters, the show has become a cultural phenomenon with a lasting legacy in both television and pop culture.",
       posterUrl: "/img/the_simpsons.jpg",
       rating: 8.7,
       releaseYear: 1989,
       genres: new List<string>{"Animation", "Comedy", "Sitcom"},
       movieHour: "35+ seasons, 700+ episodes",
       director: "Matt Groening, James L. Brooks, Sam Simon",
       writer: "Matt Groening, James L. Brooks, Matt Selman",
       actors: new List <string>{"Dan Castellaneta", "Julie Kavner", "Nancy Cartwright", "Yeardley Smith", "Hank Azaria"},
       trailer: "https://www.youtube.com/embed/XPG0MqIcby8"

    ),

    new Movie(

       title: "The Sopranos",
       description: "The Sopranos is a critically acclaimed crime drama series that delves into the life of mob boss Tony Soprano as he balances his criminal empire with family responsibilities and personal struggles. Known for its deep character development, psychological complexity, and dark humor, the show explores themes of loyalty, power, and the impact of organized crime on personal and professional life.",
       posterUrl: "/img/the_sopranos.jpeg",
       rating: 9.2,
       releaseYear: 1999,
       genres: new List<string>{"Crime", "Drama", "Thriller"},
       movieHour: "6 seasons, 86 episodes",
       director: "David Chase",
       writer: "David Chase",
       actors: new List<string>{"James Gandolfini", "Edie Falco", "Lorraine Bracco", "Michael Imperioli", "Dominic Chianese"},
       trailer: "https://www.youtube.com/embed/KMx4iFcozK0"

    ),

                };
    }

}
}

