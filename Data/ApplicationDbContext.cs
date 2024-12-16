// using Microsoft.EntityFrameworkCore;
// using MyWebApp.Models;

// namespace MyWebApp.Data
// {
//     public class ApplicationDbContext : DbContext
//     {
//         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//             : base(options)
//         {
//         }

//         public DbSet<Movie> Movies { get; set; } = null!;
//         public DbSet<Genre> Genres { get; set; } = null!;
//         public DbSet<Actor> Actors { get; set; } = null!;

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);

//             // Bileşik Anahtarlar
//             modelBuilder.Entity<MovieActor>()
//                 .HasKey(ma => new { ma.MovieId, ma.ActorId });

//             modelBuilder.Entity<MovieGenre>()
//                 .HasKey(mg => new { mg.MovieId, mg.GenreId });

//             // İlişkiler
//             modelBuilder.Entity<MovieActor>()
//                 .HasOne(ma => ma.Movie)
//                 .WithMany(m => m.MovieActors)
//                 .HasForeignKey(ma => ma.MovieId);

//             modelBuilder.Entity<MovieActor>()
//                 .HasOne(ma => ma.Actor)
//                 .WithMany(a => a.MovieActors)
//                 .HasForeignKey(ma => ma.ActorId);

//             modelBuilder.Entity<MovieGenre>()
//                 .HasOne(mg => mg.Movie)
//                 .WithMany(m => m.MovieGenres)
//                 .HasForeignKey(mg => mg.MovieId);

//             modelBuilder.Entity<MovieGenre>()
//                 .HasOne(mg => mg.Genre)
//                 .WithMany(g => g.MovieGenres)
//                 .HasForeignKey(mg => mg.GenreId);
//         }
//     }
// }
