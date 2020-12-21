using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Models
{
    public class MovieActor
    {
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        [ForeignKey(nameof(Actor))]
        public int ActorId { get; set; }

        public Movie Movies { get; set; }

        public Actor Actors { get; set; }
    }
}