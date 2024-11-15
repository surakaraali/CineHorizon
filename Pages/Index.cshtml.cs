using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models; 
using System.Collections.Generic;

namespace YourProject.Pages
{
    public class IndexModel : PageModel  
    {
        public List<Movie>? Movies { get; set; }

        public void OnGet() 
        {
            
            Movies = new List<Movie>
            {
            new Movie("The Godfather","Michael, the young and idealistic son of Vito Corleone, the head of the most powerful Mafia clan in New York, returns home as a war hero and is determined to live his own life. But tragic circumstances make him face the legacy of his family.","/img/godfather.jpeg",9.2,1972,"Gangster","Tragedy","Drama","Crime","2h 55m","Francis Ford Coppola","Mario Puzo and Francis Ford Coppola","Marlon Brando","Al Pacino","James Caan"),
            new Movie("Fight Club","An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.","/img/fight_club.jpeg",8.8,1999,"Drama","Psychologic","Action","Adventure","2h 19m","David Fincher","Chuck Palahniuk and Jim Uhls","Brad Pitt","Edward Norton","Meat Loaf"),
            new Movie("Cumhuriyet Şarkısı", "A thief who steals corporate secrets through dream-sharing technology.", "/img/cumhuriyet_sarkısı.jpg", 8.8, 2010,"Drama","History","Documentery","Romantic","2h 8m","Yağız Alp Akaydın","BKM","Salih Bademci","Birce Akalay","Ertan Saban"),
            new Movie("Matrix","When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.","/img/matrix.jpeg",8.7,1999,"Action","Sci-fi","Epic","Adventure","2h 16m","Lana Wachowski and Lilly Wachowski","Lana Wachowski and Lilly Wachowski","Keanu Reeves","Laurence Fishburne"," Carrie-Anne Moss"),
            new Movie("Panda Bear Africa", "A panda travels from China to Africa, facing hippos, hyenas, gorillas. He rescues his kidnapped dragon friend, makes new friends, and protects their jungle home.", "/img/panda_bear_africa.jpeg",5.5, 2024,"Animation","Family","Comedy","Adventure","1h 24 m","Karsten Killerich and Richard Claus","Rob Sprackling","Maurits Delchot","Thom Hoffman","Silas Lekgoathi"),
            new Movie("Inside Out 2", "A sequel that features Riley entering puberty and experiencing brand new, more complex emotions as a result. As Riley tries to adapt to her teenage years, her old emotions try to adapt to the possibility of being replaced.", "/img/inside_out_2.jpeg", 7.6, 2024,"Animation","Adventure","Comedy","Family","1h 36m","Kelsey Menn","Meg LeFauve and Dave Holstein","Amy Poehler","Maya Hawke","Kensington Tallman"),
            new Movie("Inside Out", "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.", "/img/inside_out.jpeg", 8.1, 2015,"Animation","Adventure","Comedy","Family","1h 35m","Pete Docter and Ronnie Del Carmen","Pete Docter, Ronnie Del Carmen and Meg LeFauve","Amy Poehler","Bill Hader","Lewis Black"),
            new Movie("Interstellar","When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.","/img/interstellar.jpeg",8.7,2014,"Sci-fi","Epic","Adventure","Drama","2h 49m","Christopher Nolan","Jonathan Nolan and Christopher Nolan","Matthew McConaughey","Anne Hathaway","Jessica Chastain"),
            new Movie("The Prestige","Set in London in the 1800s, two rival magicians read each others diary containing the secrets of their magic tricks and personal life. As we go back in time when the diaries were written, both magicians become obsessed with their rival's best trick. The tricks, as shown to the audience, look the same, but neither magician can figure out how his opponent does it.","/img/the_prestige.jpeg",8.5,2006,"Drama","Mystery","Sci-fi","Thriller","2h 10m","Christopher Nolan","Jonathan NolanChristopher and NolanChristopher Priest","Christian Bale","Hugh Jackman","Scarlett Johansson"),
            new Movie("The Silence of the Lambs","A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.","/img/the_silence_of_the_lambs.jpeg",8.6,1991,"Psychological","Thriller","Drama","Crime","1h 58m","Jonathan Demme","Thomas Harris and Ted Tally","Jodie Foster","Anthony Hopkins","Scott Glenn"),
            new Movie("The Star Wars","After the Empire overpowers the Rebel Alliance, Luke Skywalker begins his Jedi training with Yoda. At the same time, Darth Vader and bounty hunter Boba Fett pursue his friends across the galaxy.","/img/the_star_wars.jpeg",8.7,1980,"Sci-fi","Epic","Action","Fantasy","2h 4m", "Irvin Kershner","Leigh Brackett and Lawrence KasdanGeorge Lucas","Mark Hamill","arrison Ford","Carrie Fisher"),
            new Movie("The Schindler's List","In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.","/img/schindler_s_list.jpeg",9,1993,"Historical","Epic","Drama","Biography","3h 15m","Steven Spielberg","Thomas Keneally and teven Zaillian","Liam Neeson","Ralph Fiennes","Ben Kingsley")
                
            };
        }
    }
}

