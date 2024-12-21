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


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CINEHORIZON_DB_CONNECTION") ??
                                   "Host=localhost;Database=CineHorizonDB;Username=postgres;Password=zeynep123");

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

        modelBuilder.Entity<Movie>()
            .Property(m => m.Type)
            .HasColumnName("type"); 

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
            entity.HasKey(e => e.Id).HasName("comments_pkey");

            entity.ToTable("comments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MovieId).HasColumnName("movieid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedAt).HasColumnName("createdat");

            entity.HasOne<Movie>()
                .WithMany()
                .HasForeignKey(e => e.MovieId)
                .HasConstraintName("FK_Movie_Comment");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}