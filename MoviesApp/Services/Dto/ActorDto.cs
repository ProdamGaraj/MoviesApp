using System;
namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
