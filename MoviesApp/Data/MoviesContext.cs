using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;


namespace MoviesApp.Data
{
    public class MoviesContext : IdentityDbContext<ApplicationUser>
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>(e => e.HasKey(ma => new { ma.ActorId, ma.MovieId }));
            base.OnModelCreating(modelBuilder);
        }
    }
}