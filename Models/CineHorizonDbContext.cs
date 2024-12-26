using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models;

public partial class CineHorizonDbContext : DbContext
{
    public CineHorizonDbContext()
    {
    }

    public CineHorizonDbContext(DbContextOptions<CineHorizonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor>? Actors { get; set; }

    public virtual DbSet<Genre>? Genres { get; set; }

    public virtual DbSet<Movie>? Movies { get; set; }

    public virtual DbSet<Comment>? Comments { get; set; }

    public virtual DbSet<User>? Users { get; set; }

    public virtual DbSet<MovieLike>? MovieLikes { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CINEHORIZON_DB_CONNECTION") ??
                                   "Host=localhost;Database=CineHorizonDB;Username=postgres;Password=sura123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Actorid).HasName("actors_pkey");

            entity.ToTable("actors");

            entity.Property(e => e.Actorid).HasColumnName("actorid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MovieLike>(entity =>
        {
            entity.HasKey(ml => new { ml.MovieId, ml.UserId }).HasName("movie_likes_pkey");

            entity.ToTable("movielikes");

            entity.HasOne(ml => ml.Movie)
                .WithMany(m => m.MovieLikes)
                .HasForeignKey(ml => ml.MovieId)
                .HasConstraintName("fk_movie_like_movieid");

            entity.HasOne(ml => ml.User)
                .WithMany(u => u.LikedMovies)
                .HasForeignKey(ml => ml.UserId)
                .HasConstraintName("fk_movie_like_userid");

            entity.Property(ml => ml.MovieId).HasColumnName("movieid");
            entity.Property(ml => ml.UserId).HasColumnName("userid");
        });


        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Genreid).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Genreid).HasColumnName("genreid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Movieid).HasName("movies_pkey");

            entity.ToTable("movies");

            entity.Property(e => e.Movieid).HasColumnName("movieid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .HasColumnName("director");
            entity.Property(e => e.Moviehour)
                .HasMaxLength(10)
                .HasColumnName("moviehour");
            entity.Property(e => e.Posterurl).HasColumnName("posterurl");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Releaseyear).HasColumnName("releaseyear");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Trailer).HasColumnName("trailer");
            entity.Property(e => e.Writer)
                .HasMaxLength(255)
                .HasColumnName("writer");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasMany(d => d.Actors).WithMany(p => p.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "Movieactor",
                    r => r.HasOne<Actor>().WithMany()
                        .HasForeignKey("Actorid")
                        .HasConstraintName("movieactors_actorid_fkey"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("Movieid")
                        .HasConstraintName("movieactors_movieid_fkey"),
                    j =>
                    {
                        j.HasKey("Movieid", "Actorid").HasName("movieactors_pkey");
                        j.ToTable("movieactors");
                        j.IndexerProperty<int>("Movieid").HasColumnName("movieid");
                        j.IndexerProperty<int>("Actorid").HasColumnName("actorid");
                    });

            entity.HasMany(d => d.Genres).WithMany(p => p.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "Moviegenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("Genreid")
                        .HasConstraintName("moviegenres_genreid_fkey"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("Movieid")
                        .HasConstraintName("moviegenres_movieid_fkey"),
                    j =>
                    {
                        j.HasKey("Movieid", "Genreid").HasName("moviegenres_pkey");
                        j.ToTable("moviegenres");
                        j.IndexerProperty<int>("Movieid").HasColumnName("movieid");
                        j.IndexerProperty<int>("Genreid").HasColumnName("genreid");
                    });
        });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.CommentId).HasName("comments_pkey");

                entity.ToTable("comments");

                entity.Property(e => e.CommentId).HasColumnName("id");
                entity.Property(e => e.MovieId).HasColumnName("movieid");
                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.CreatedAt).HasColumnName("createdat");

                entity.HasOne(c => c.Movie)
                    .WithMany()
                    .HasForeignKey(c => c.MovieId)
                    .HasConstraintName("FK_Movie_Comment");

                entity.HasOne(c => c.User)
                    .WithMany()
                    .HasForeignKey(c => c.UserId)
                    .HasConstraintName("FK_Comment_User");
            });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Uuid).HasColumnName("uuid");
            entity.Property(e => e.Email)
             .IsRequired()
            .HasMaxLength(255)
        .HasColumnName("email");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .HasColumnName("surname");
        });




        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}